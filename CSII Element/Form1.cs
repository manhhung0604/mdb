using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace CSII_Element
{
    public partial class Form1 : Form
    {
        public List<Element> listOfElements = new List<Element>();
        public Element elements = new Element();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openAccessFile = new OpenFileDialog();
            openAccessFile.Filter = "Access Files 2010|*.accdb|All files|*.*";
            if (openAccessFile.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openAccessFile.FileName;
                txtAccessPath.Text = fileName;
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = null;
            string strConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtAccessPath.Text;
            conn = new OleDbConnection(strConnection);
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from INPUT_BASIC_ELEMENT_DATA";
            command.Connection = conn;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                object key = reader[0];
                /*Element rec = new Element();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rec.Pressure.Add(Convert.ToDouble(reader[i]));
                }*/
                
                elements.FromNode = Convert.ToInt32(reader[4]);
                elements.ToNode = Convert.ToInt32(reader[5]);
                if (!String.IsNullOrEmpty(reader[12].ToString()))
                {
                    elements.OD = (double)reader[12];
                }else
                {
                    Debug.WriteLine("Data here: " + reader[12].ToString());
                }
                
                for (int i = 16; i <= 24; i++)
                {
                    Debug.WriteLine("Data i here: " + i.ToString());
                    Debug.WriteLine("Data here: " + reader[i].ToString());
                    Debug.WriteLine("Data here: " + reader[i + 9].ToString());
                    if (!String.IsNullOrEmpty(reader[i].ToString()))
                    {
                        elements.Temperature.Add(Convert.ToDouble(reader[i].ToString()));
                        elements.Pressure.Add(Convert.ToDouble(reader[i + 9].ToString()));
                    }
                    else
                    {
                        Debug.WriteLine("Data here: " + reader[i].ToString());
                        
                    }

                    if (!String.IsNullOrEmpty(reader[i + 9].ToString()))
                    {
                        elements.Pressure.Add(Convert.ToDouble(reader[i + 9]));
                    }
                    else
                    {
                        Debug.WriteLine("Data here: " + reader[i + 9].ToString());

                    }
                }
                listOfElements.Add(elements);
            }
            reader.Close();
         }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listOfElements.ToString());
        }
    }
}
