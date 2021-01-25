using LinqTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Task1_Click(object sender, EventArgs e)
        {
            var query=Methods.Methods.Task1();
            rtb_Result.Text = "";
            foreach(var i in query)
            {
                rtb_Result.Text += i+",";
            }
            
        }

        private void btn_Task2_Click(object sender, EventArgs e)
        {
            var query = Methods.Methods.Task2();
            rtb_Result.Text = "";
            foreach (var i in query)
            {
                rtb_Result.Text += i + ",";
            }
        }

        private void btn_Task4_Click(object sender, EventArgs e)
        {
            var query = Methods.Methods.Task4();
            rtb_Result.Text = "";
            foreach (var i in query)
            {
                rtb_Result.Text += i + ",";
            }

        }

        private void btn_Task5_Click(object sender, EventArgs e)
        {
            var query = Methods.Methods.Task5();
            rtb_Result.Text = "";
            foreach (var i in query)
            {
                rtb_Result.Text += i + Environment.NewLine;
            }
        }

        private void btn_Task6_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = "";
            List<Category> categories = new List<Category>()
            {
             new Category{ Name = "Milk", Country ="Belorussia" },
             new Category{ Name = "Juice", Country ="Poland" }
            };
            List<Product> products = new List<Product>()
            {
             new Product{Name="Yoghurt", Category ="Milk"},
             new Product{Name="Cheese", Category ="Milk"},
             new Product{Name="Fruktoviy sad", Category ="Juice"}
            };

            var query = products.Join(categories, str1 => str1.Category,
                      str2 => str2.Name,
                      (str1, str2) => new 
                      {
                          Name = str1.Name,
                          Category = str1.Category,
                          Country = str2.Country
                      }).ToList();
            foreach (var i in query)
            {
                rtb_Result.Text += i.Name+"-"+i.Category+"("+i.Country+")"+ Environment.NewLine;
            }

        }

        private void btn_Task3_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = "";
            List<User> users = new List<User>();
            users.Add(new User { Name = "Asim", Age = 20 });
            users.Add(new User { Name = "Aygun", Age = 25 });
            var query = from user in users
                        select new
                        {
                            Name = user.Name,
                            birthDate = DateTime.Now.Year - user.Age
                        };
            foreach (var i in query)
            {
                rtb_Result.Text += i.Name + "-" +i.birthDate + Environment.NewLine;
            }

        }
    }
}
