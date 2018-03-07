
using Car_App.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Car_App
{
    public partial class Dashboard : Form
    {
        private PictureBox pictureBox1;
        private XmlDocument xmlDoc = new XmlDocument();
        private ListBox bmwTextBox;
        private Label text = new Label();
        private Label fileUploaded;
        private Label carTitle;
        private Button addImage;
        private Button goBtn;
        private string MakeText;
        private string ModelText;
        private string YearText;
        private string PriceText;
        private TextBox makeTextBox;
        private TextBox modelTextBox;
        private TextBox yearTextBox;
        private TextBox priceTextBox;
        private ComboBox modelComboBox;
        private ComboBox makeComboBox;
        private ToolStripMenuItem objName;
        private Color bgColor = new Color();
        private ToolStripMenuItem objName2;
        private Color bgColor2 = new Color();
        private LinkLabel objName3;
        private Color bgColor3 = new Color();
        private string filepath;
        private int count = 0;
        private string img = "";
        private string filename = "";
        private string makeSelect = "";
        private string modelSelect = "";
        private string rootDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            adminPanel.Visible = true;
            menuStripAdmin.Visible = true;
            menuStripMCars.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, EventArgs e)
        {
            manageCarPanel.Visible = true;
            adminPanel.Visible = false;
            menuStripAdmin.Visible = false;
            menuStripMCars.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");
            editProfilePanel.Visible = false;
            adminLink.BackColor = DefaultBackColor;
            adminLink.LinkColor = Color.Black;
            objName3 = adminLink;
        }

        private void manageCarPanel_Enter(object sender, EventArgs e)
        {

        }

        private void listAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");
            int num = 10;
            listAllCarsPanel.Controls.Clear();

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                count++;
                CreateImageAndText(num);
                img = node.LastChild.InnerText;
                pictureBox1.Image = Image.FromFile(rootDir + @"\Images\" + img);
            
                listAllCarsPanel.Controls.Add(pictureBox1);
                
                foreach (XmlNode child in node)
                {
                    if (child.Name.Equals("img"))
                        continue;
                    bmwTextBox.Items.Add(child.Name + ": " + child.InnerText + "\n");
                }
                
                listAllCarsPanel.Controls.Add(bmwTextBox);
                num += 300;
            }
        }

        private void findCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");
            listAllCarsPanel.Controls.Clear();
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(180, 10);
            textBox.Name = "searchBox";
            textBox.Size = new Size(180, 30);
            listAllCarsPanel.Controls.Add(textBox);
            Button searchBtn = new Button();
            searchBtn.Location = new System.Drawing.Point(380, 9);
            searchBtn.Name = "searchBtn";
            searchBtn.Text = "Search";
            searchBtn.Click += new EventHandler(this.SearchBtn_Click);

            listAllCarsPanel.Controls.Add(searchBtn);
        }

        // Search button event handler method
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            listAllCarsPanel.Controls.Remove(text);
            xmlDoc.Load("CarData.xml");
            bool isNotFound = true;
            int num = 40;
            if (listAllCarsPanel.Controls.Contains(pictureBox1))
            {
                listAllCarsPanel.Controls.RemoveAt(listAllCarsPanel.Controls.IndexOf(pictureBox1));
                listAllCarsPanel.Controls.RemoveAt(listAllCarsPanel.Controls.IndexOf(bmwTextBox));
            }

            string textBoxValue = listAllCarsPanel.Controls["searchBox"].Text;

            if(!(string.IsNullOrEmpty(textBoxValue)))
            { 
                foreach (XmlNode node in xmlDoc.DocumentElement)
                {
                    count++;
                    if (node.ChildNodes[1].InnerText.Contains(textBoxValue))
                    {
                        isNotFound = false;
                        CreateImageAndText(num);
                        img = node.LastChild.InnerText;
                        pictureBox1.Image = Image.FromFile(rootDir + @"\Images\" + img);
                        listAllCarsPanel.Controls.Add(pictureBox1);
                       
                        foreach (XmlNode child in node)
                        {
                            if (child.Name.Equals("img"))
                                continue;
                            bmwTextBox.Items.Add(child.Name + ": " + child.InnerText + "\n");
                        }
                        listAllCarsPanel.Controls.Add(bmwTextBox);
                        num += 290;
                    }
                }
                if(isNotFound)
                    SearchNotFound();
            }
            else
                SearchNotFound();
        }

        public void SearchNotFound()
        {
            text.Text = "Search not found";
            text.Name = "srchResult1";
            text.Location = new System.Drawing.Point(270, 50);
            listAllCarsPanel.Controls.Add(text);
        }

        public void CreateImageAndText(int num)
        {
            // Creates picture box
            pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(160, num);
            pictureBox1.Name = "pictureBox" + count;
            pictureBox1.Size = new Size(300, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Creates list box
            bmwTextBox = new ListBox();
            bmwTextBox.Name = "bmwListBox" + count;
            bmwTextBox.Location = new System.Drawing.Point(150, num + 170);
            bmwTextBox.Size = new Size(310, 110);
            bmwTextBox.Font = new Font(FontFamily.GenericSerif, 16.25f, FontStyle.Bold, GraphicsUnit.Point);
        }

        public void AddCar(object sender, EventArgs e)
        {
            MakeText = listAllCarsPanel.Controls["MakeText"].Text;
            ModelText = listAllCarsPanel.Controls["modelText"].Text;
            YearText = listAllCarsPanel.Controls["YearText"].Text;
            PriceText = listAllCarsPanel.Controls["PriceText"].Text;

            if (!string.IsNullOrEmpty(filepath))
            {
                if (!string.IsNullOrEmpty(MakeText))
                {
                    if (!string.IsNullOrEmpty(ModelText))
                    {
                        if (!string.IsNullOrEmpty(YearText))
                        {
                            if (!string.IsNullOrEmpty(PriceText))
                            {
                                Bitmap img = new Bitmap(filepath);
                                Label carAdded = new Label();
                                carAdded.Location = new System.Drawing.Point(290, 320);
                                carAdded.Name = "carAdded";
                                carAdded.Text = "Car added...";
                                img.Save(rootDir + @"\Images\" + filename);

                                // Create xml elements
                                XmlElement parentElement = xmlDoc.CreateElement("Car");
                                XmlElement make = xmlDoc.CreateElement("Make");
                                make.InnerText = MakeText;
                                XmlElement model = xmlDoc.CreateElement("Model");
                                model.InnerText = ModelText;
                                XmlElement year = xmlDoc.CreateElement("Year");
                                year.InnerText = YearText;
                                XmlElement price = xmlDoc.CreateElement("Price");
                                price.InnerText = PriceText;
                                XmlElement imgName = xmlDoc.CreateElement("img");
                                imgName.InnerText = filename;

                                // Append xml child elements to parent
                                parentElement.AppendChild(make);
                                parentElement.AppendChild(model);
                                parentElement.AppendChild(year);
                                parentElement.AppendChild(price);
                                parentElement.AppendChild(imgName);
                                xmlDoc.DocumentElement.AppendChild(parentElement);
                                xmlDoc.Save("CarData.xml");

                                listAllCarsPanel.Controls.Add(carAdded);
                            }
                            else
                                MessageBox.Show("Please fill in the price field.",
                                                "Missing information", 
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Please fill in the year field.",
                                            "Missing information", 
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Please fill in the model field.",
                                        "Missing information",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Please fill in the make field.",
                                    "Missing information", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select an image.", 
                                "Missing information",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
        }

        public void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //For any other formats
            openFile.Title = "Select file to be upload";
            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                listAllCarsPanel.Controls.Remove(fileUploaded);
                filepath = openFile.FileName.ToString();
                filename = filepath.Substring(filepath.LastIndexOf('\\')+1);
                fileUploaded.Text = filename;
                listAllCarsPanel.Controls.Add(fileUploaded);
            }

        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listAllCarsPanel.Controls.Clear();

            addImage = new Button();
            addImage.Location = new System.Drawing.Point(190, 60);
            addImage.Name = "Add_image";
            addImage.Text = "Add image";
            addImage.BackColor = Color.White;
            addImage.Click += new EventHandler(this.AddImage);

            listAllCarsPanel.Controls.Add(addImage);

            fileUploaded = new Label();
            fileUploaded.Name = "filenameLabel";
            fileUploaded.Location = new System.Drawing.Point(280, 65);
            fileUploaded.Width = 356;
            fileUploaded.Text = "No image added";

            listAllCarsPanel.Controls.Add(fileUploaded);

            Label Make = new Label();
            Make.Text = "Make:";
            Make.Name = "MakeLabel";
            Make.Font = new Font(FontFamily.GenericSerif, 12.25f, FontStyle.Bold, GraphicsUnit.Point);
            Make.Location = new System.Drawing.Point(190, 100);
            Make.Size = new Size(80, 40);

            listAllCarsPanel.Controls.Add(Make);

            Label Model = new Label();
            Model.Text = "Model:";
            Model.Name = "ModelLabel";
            Model.Font = new Font(FontFamily.GenericSerif, 12.25f, FontStyle.Bold, GraphicsUnit.Point);
            Model.Location = new System.Drawing.Point(190, 150);
            Model.Size = new Size(80, 40);

            listAllCarsPanel.Controls.Add(Model);

            Label Year = new Label();
            Year.Text = "Year:";
            Year.Name = "YearLabel";
            Year.Font = new Font(FontFamily.GenericSerif, 12.25f, FontStyle.Bold, GraphicsUnit.Point);
            Year.Location = new System.Drawing.Point(190, 200);
            Year.Size = new Size(80, 40);

            listAllCarsPanel.Controls.Add(Year);

            Label Price = new Label();
            Price.Text = "Price:";
            Price.Name = "PriceLabel";
            Price.Font = new Font(FontFamily.GenericSerif, 12.25f, FontStyle.Bold, GraphicsUnit.Point);
            Price.Location = new System.Drawing.Point(190, 250);
            Price.Size = new Size(80, 40);

            listAllCarsPanel.Controls.Add(Price);

            makeTextBox = new TextBox();
            makeTextBox.Location = new System.Drawing.Point(270, 100);
            makeTextBox.Name = "MakeText";
            makeTextBox.Size = new Size(170, 30);

            listAllCarsPanel.Controls.Add(makeTextBox);

            modelTextBox = new TextBox();
            modelTextBox.Location = new System.Drawing.Point(270, 150);
            modelTextBox.Name = "modelText";
            modelTextBox.Size = new Size(170, 30);

            listAllCarsPanel.Controls.Add(modelTextBox);

            yearTextBox = new TextBox();
            yearTextBox.Location = new System.Drawing.Point(270, 200);
            yearTextBox.Name = "yearText";
            yearTextBox.Size = new Size(170, 30);

            listAllCarsPanel.Controls.Add(yearTextBox);

            priceTextBox = new TextBox();
            priceTextBox.Location = new System.Drawing.Point(270, 250);
            priceTextBox.Name = "priceText";
            priceTextBox.Size = new Size(170, 30);

            listAllCarsPanel.Controls.Add(priceTextBox);

            Button addCar = new Button();
            addCar.Location = new System.Drawing.Point(190, 290);
            addCar.Size = new Size(80, 40); 
            addCar.Name = "Add_car";
            addCar.Text = "Add car";
            addCar.Font = new Font(FontFamily.GenericSerif, 12.25f, FontStyle.Bold, GraphicsUnit.Point);
            addCar.Click += new EventHandler(this.AddCar);
            addCar.BackColor = Color.LightSkyBlue;
            addCar.FlatStyle = FlatStyle.Flat;

            listAllCarsPanel.Controls.Add(addCar);
        }

        private void editExistingCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");
            int num = 50;
            int itr = 0;
            Label label;
            TextBox textBox;
            Button saveBtn;
            
            listAllCarsPanel.Controls.Clear();
            
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                dynamic[] xmlNodes = new TextBox[4];
                int i = 0;
                count++;
                CreateImageAndText(num);
                img = node.LastChild.InnerText;
                pictureBox1.Image = Image.FromFile(rootDir + @"\Images\" + img);

                listAllCarsPanel.Controls.Add(pictureBox1);

                foreach (XmlNode child in node)
                {
                    itr++;
                    if (child.Name.Equals("img"))
                        continue;
                    label = new Label();
                    label.Name = child.Name + itr;
                    label.Location = new System.Drawing.Point(220, num+171);
                    label.Size = new Size(60, 40);
                    label.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
                    label.Text = child.Name+":";
                    listAllCarsPanel.Controls.Add(label);
                    textBox = new TextBox();
                    textBox.Name = child.Name + itr;
                    textBox.Location = new System.Drawing.Point(280, num+170);
                    textBox.Text = child.InnerText;
                    listAllCarsPanel.Controls.Add(textBox);
                    num+=50;
                    xmlNodes[i] = textBox;
                    i++;
                }
                // Create save notification label
                Label saveNotice = new Label();
                saveNotice.Location = new System.Drawing.Point(300, num + 169);
                saveNotice.Name = "saveNtice" + count;
                // Create a new save button
                saveBtn = new Button();
                saveBtn.Location = new System.Drawing.Point(220, num + 161);
                saveBtn.Name = "saveBtn"+count;
                saveBtn.Text = "Save";
                saveBtn.Height = 30;
                saveBtn.BackColor = Color.FloralWhite;
                saveBtn.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
                saveBtn.BackColor = Color.LightSkyBlue;
                saveBtn.FlatStyle = FlatStyle.Flat;
                saveBtn.Click += (s, ev) => {
                    TextBox[] items = new TextBox[4];
                    string saveNm = saveNotice.Name;
                    Array.Copy(xmlNodes, items, 4);
                    node.ChildNodes[0].InnerText = items[0].Text;
                    node.ChildNodes[1].InnerText = items[1].Text;
                    node.ChildNodes[2].InnerText = items[2].Text;
                    node.ChildNodes[3].InnerText = items[3].Text;
                    xmlDoc.Save("CarData.xml");
                    saveNotice.Text = "Saved changes.";
                    listAllCarsPanel.Controls.Add(saveNotice);
                };
                listAllCarsPanel.Controls.Add(saveNotice);
                listAllCarsPanel.Controls.Add(saveBtn);
                num += 190;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editProfilePanel.Visible = false;
            changePasswordPanel.Visible = true;
            Label userName = new Label();
            userName.Name = "userNameChange";
            userName.Text = "User name:";
            userName.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
            userName.Width = 79;
            userName.Location = new System.Drawing.Point(205, 90);

            Label password = new Label();
            password.Name = "password1";
            password.Text = "Password:";
            password.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
            password.Width = 70;
            password.Location = new System.Drawing.Point(205, 130);

            TextBox userTextBox = new TextBox();
            userTextBox.Name = "userTextBox";
            userTextBox.Location = new System.Drawing.Point(285,90);
            userTextBox.Width = 150;

            TextBox passTextBox = new TextBox();
            passTextBox.Name = "passTextBox";
            passTextBox.Location = new System.Drawing.Point(285, 130);
            passTextBox.Width = 150;

            Button enter = new Button();
            enter.Name = "enterBtn";
            enter.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
            enter.Text = "Enter";
            enter.Height = 40;
            enter.Location = new System.Drawing.Point(210, 170);
            enter.Click += new EventHandler(this.checkChangePassword_Click);

            changePasswordPanel.Controls.Add(userName);
            changePasswordPanel.Controls.Add(password);
            changePasswordPanel.Controls.Add(userTextBox);
            changePasswordPanel.Controls.Add(passTextBox);
            changePasswordPanel.Controls.Add(enter);
        }

        private void checkChangePassword_Click(object sender, EventArgs e)
        {
            string userName = changePasswordPanel.Controls["userTextBox"].Text;
            string password = changePasswordPanel.Controls["passTextBox"].Text;

            if (!(string.IsNullOrEmpty(userName)) && !(string.IsNullOrEmpty(password)))
            {
                if (userName.Equals(Login.GetUserName()) && password.Equals(Login.GetPassword()))
                {
                    changePasswordPanel.Controls.Clear();
                    Label newName = new Label();
                    newName.Name = "userNameChange";
                    newName.Text = "New User name:";
                    newName.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
                    newName.Width = 110;
                    newName.Location = new System.Drawing.Point(185, 90);

                    Label newPass = new Label();
                    newPass.Name = "password1";
                    newPass.Text = "New Password:";
                    newPass.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
                    newPass.Width = 110;
                    newPass.Location = new System.Drawing.Point(185, 130);

                    TextBox userTextBox = new TextBox();
                    userTextBox.Name = "newUserTextBox";
                    userTextBox.Location = new System.Drawing.Point(305, 90);
                    userTextBox.Width = 150;

                    TextBox passTextBox = new TextBox();
                    passTextBox.Name = "newPassTextBox";
                    passTextBox.Location = new System.Drawing.Point(305, 130);
                    passTextBox.Width = 150;

                    Button changePass = new Button();
                    changePass.Name = "changePass";
                    changePass.Font = new Font(FontFamily.GenericSerif, 10.25f, FontStyle.Bold, GraphicsUnit.Point);
                    changePass.Text = "Change password";
                    changePass.Size = new Size(140, 40);
                    changePass.Location = new System.Drawing.Point(185, 170);
                    changePass.Click += (s, ev) =>
                    {
                        if (!(string.IsNullOrEmpty(userTextBox.Text)) && !(string.IsNullOrEmpty(passTextBox.Text)))
                        {
                            Login.user_pass(userTextBox.Text, passTextBox.Text);
                            MessageBox.Show("User name and password changed.");
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all fields.");
                        }
                    };

                    changePasswordPanel.Controls.Add(newName);
                    changePasswordPanel.Controls.Add(newPass);
                    changePasswordPanel.Controls.Add(userTextBox);
                    changePasswordPanel.Controls.Add(passTextBox);
                    changePasswordPanel.Controls.Add(changePass);
                }
                else
                {
                    MessageBox.Show("User name or password not equal");
                }
            }
            else
            {
                MessageBox.Show("Please fill in fields");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to logout.";
            var result = MessageBox.Show(message, "Dashboard closing",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var login = new Login();
                login.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            
        }

        private void CarDetailsGo_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");

            if (listAllCarsPanel.Controls.Contains(pictureBox1))
            {
                listAllCarsPanel.Controls.RemoveAt(listAllCarsPanel.Controls.IndexOf(pictureBox1));
                listAllCarsPanel.Controls.RemoveAt(listAllCarsPanel.Controls.IndexOf(bmwTextBox));
                listAllCarsPanel.Controls.RemoveAt(listAllCarsPanel.Controls.IndexOf(carTitle));
            }

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                count++;
                if (node.FirstChild.InnerText.Equals(makeSelect))
                {
                    if (node.ChildNodes[1].InnerText.Equals(modelSelect))
                    {

                        // Creates picture box
                        pictureBox1 = new PictureBox();
                        pictureBox1.Location = new System.Drawing.Point(40, 90);
                        pictureBox1.Name = "pictureBox" + count;
                        pictureBox1.Size = new Size(290, 169);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                        // Creates list box
                        bmwTextBox = new ListBox();
                        bmwTextBox.Name = "bmwListBox" + count;
                        bmwTextBox.Location = new System.Drawing.Point(340, 110);
                        bmwTextBox.Size = new Size(250, 120);
                        bmwTextBox.Font = new Font(FontFamily.GenericSerif, 14.25f, FontStyle.Bold, GraphicsUnit.Point);
                        img = node.LastChild.InnerText;
                        pictureBox1.Image = Image.FromFile(rootDir + @"\Images\" + img);
                        listAllCarsPanel.Controls.Add(pictureBox1);

                        // Create label
                        carTitle = new Label();
                        carTitle.Name = "carTitle";
                        carTitle.Location = new System.Drawing.Point(70, 60);
                        carTitle.Size = new Size(250, 40);
                        carTitle.Font = new Font(FontFamily.GenericSerif, 13.25f, FontStyle.Bold, GraphicsUnit.Point);
                        listAllCarsPanel.Controls.Add(carTitle);

                        foreach (XmlNode child in node)
                        {
                            if (child.Name.Equals("img"))
                                continue;
                            bmwTextBox.Items.Add(child.Name + ": " + child.InnerText + "\n\n\n");
                        }
                        carTitle.Text = makeSelect + " " + modelSelect;
                        bmwTextBox.Items.Add("\n\n");
                        listAllCarsPanel.Controls.Add(bmwTextBox);
                    }
                }
            }

        }

        private void viewCarDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("CarData.xml");
            listAllCarsPanel.Controls.Clear();
            modelComboBox = new ComboBox();
            makeComboBox = new ComboBox();
            makeComboBox.Name = "makeCombo";
            makeComboBox.Text = "Select a make";
            makeComboBox.Size = new Size(100, 40);
            makeComboBox.Location = new System.Drawing.Point(140, 10);
            makeComboBox.SelectedIndexChanged += (s, ev) => {
                modelComboBox.Enabled = true;
                goBtn.Enabled = false;
                modelComboBox.Items.Clear();
                modelComboBox.Text = "Select a model";
                foreach (XmlNode node in xmlDoc.DocumentElement)
                    if (node.FirstChild.InnerText.Equals(makeComboBox.SelectedItem))
                        modelComboBox.Items.Add(node.ChildNodes[1].InnerText);
            };

            
            modelComboBox.Name = "modelCombo";
            modelComboBox.Text = "Select a model";
            modelComboBox.Size = new Size(150, 40);
            modelComboBox.Enabled = false;
            modelComboBox.Location = new System.Drawing.Point(255, 10);
            modelComboBox.SelectedIndexChanged += (s, ev) => {
                goBtn.Enabled = true;
                makeSelect = makeComboBox.SelectedItem.ToString();
                modelSelect = modelComboBox.SelectedItem.ToString();
            };

            goBtn = new Button();
            goBtn.Name = "goBtn";
            goBtn.Text = "Go";
            goBtn.Height = 25;
            goBtn.Enabled = false;
            goBtn.Location = new System.Drawing.Point(420, 9);
            goBtn.Click += new EventHandler(this.CarDetailsGo_Click);

            listAllCarsPanel.Controls.Add(makeComboBox);
            listAllCarsPanel.Controls.Add(modelComboBox);
            listAllCarsPanel.Controls.Add(goBtn);

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                // Check if combobox already contains the make 
                if(!makeComboBox.Items.Contains(node.FirstChild.InnerText))
                    makeComboBox.Items.Add(node.FirstChild.InnerText);
            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editProfilePanel.Visible = true;
        }

        private void ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (objName != null && !string.IsNullOrEmpty(objName.Text))
            {
                objName.BackColor = bgColor;
                objName.ForeColor = Color.White;
                objName = ((ToolStripMenuItem)sender);
                objName.BackColor = DefaultBackColor;
                objName.ForeColor = Color.Black;
            }
            else
            {
                objName = ((ToolStripMenuItem)sender);
                bgColor = objName.BackColor;
                objName.BackColor = DefaultBackColor;
                objName.ForeColor = Color.Black;
            }

            
        }

        private void ManageCarToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (objName2 != null && !string.IsNullOrEmpty(objName2.Text))
            {
                objName2.BackColor = bgColor2;
                objName2.ForeColor = Color.White;
                objName2 = ((ToolStripMenuItem)sender);
                objName2.BackColor = DefaultBackColor;
                objName2.ForeColor = Color.Black;
            }
            else
            {
                objName2 = ((ToolStripMenuItem)sender);
                bgColor2 = objName2.BackColor;
                objName2.BackColor = DefaultBackColor;
                objName2.ForeColor = Color.Black;
            }
        }

        private void LinkItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (!objName3.Text.Equals(((LinkLabel)sender).Text))
            {
                objName3.BackColor = ((LinkLabel)sender).BackColor;
                objName3.LinkColor = ((LinkLabel)sender).LinkColor;
                objName3 = ((LinkLabel)sender);
                objName3.BackColor = DefaultBackColor;
                objName3.LinkColor = Color.Black;
            }
        }
    }
}
