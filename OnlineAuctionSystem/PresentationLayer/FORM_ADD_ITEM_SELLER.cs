using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using OnlineAuctionSystem.BussinessLogicLayer;

namespace OnlineAuctionSystem.PresentationLayer
{
    
    public partial class FORM_ADD_ITEM_SELLER : Form
    {
        //create Object validation
        Validation validation = new Validation();

        //Seller ID 
        private  int Seller_ID;

        //Seller ID 
        private int Session_Id;

        public FORM_ADD_ITEM_SELLER(int Seller_Id ,int sessionId)
        {
            InitializeComponent();
            this.Seller_ID = Seller_Id;
            this.Session_Id = sessionId;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
                //Validate Data
                if (txtItemName.Text == string.Empty || txtItemDescription.Text == string.Empty || txtItemName.Text == string.Empty || picItemPicture.Image == null)
                {
                    MessageBox.Show("Please Complete Data !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            if (txtItemName.Text.Count() >= 50 || txtInitailPrice.Text.Count() >=50)
            {
                MessageBox.Show("Please Inter Vaild Data !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check  Name Correctness
            bool checkNameCorrectness;
                checkNameCorrectness = validation.IsAddres(txtItemName.Text);
                if (checkNameCorrectness == false)
                {
                    MessageBox.Show("Please enter a correct Name !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //check  Description Correctness
                bool checkDescriptionCorrectness;
                checkDescriptionCorrectness = validation.IsAddres(txtItemDescription.Text);
                if (checkDescriptionCorrectness == false)
                {
                    MessageBox.Show("Please enter a correct Description !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Check price Correctness
                bool checkPrice;
                checkPrice = (validation.IsPrice(txtInitailPrice.Text));
                if (checkPrice == false)
                {
                    MessageBox.Show("Please enter A Correct price ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /////////////////////////////////////////////////////////////////////


                //Get Item Id From Data Base First Select Max Id then Add 1 to Id
                int ItemId;
                DataTable Dt = new DataTable();
                //Database Instance
                DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
                dataBaseHelperL.Open();
                Dt = dataBaseHelperL.SelectData("SP_SelectMaxItemId", null);
                dataBaseHelperL.Close();
                if (Dt.Rows[0]["ID"].ToString() == string.Empty)
                {
                    ItemId = 1;
                }
                else
                {
                    ItemId = Convert.ToInt32(Dt.Rows[0]["ID"].ToString()) + 1;
                }

                //Save picture
                MemoryStream ms = new MemoryStream();
                picItemPicture.Image.Save(ms, picItemPicture.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                //Create Item Object
                Item _item = new Item(ItemId, txtItemName.Text, txtItemDescription.Text, byteImage, Convert.ToSingle(txtInitailPrice.Text), Seller_ID);

                //seller Object to add item
                Seller seller = new Seller();
                seller.add_Item(_item, Session_Id);

                MessageBox.Show("Item Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            
            
    }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Open File Dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.JPG; *.PNG; *.GIP; *.BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picItemPicture.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

  