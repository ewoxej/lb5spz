using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Варіант 4. Додаток зберігає інформацію про предметах, студентів та їх оцінках.
//Через Діалогове вікно можна редагувати списки студентів (додавання, видалення, зміна прізвища)
//    і предметів (додавання, зміна назви, видалення), додавання оцінок. Реалізувати сортування
//        списку за прізвищем студента або назвою предмета.Реалізувати сортування по успішності студентів.
namespace lb5spz
{

    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        BindingSource binding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            students.Append(new Student { name = "aa", group = "dd" });
            binding.DataSource = students;
            dataGridView1.DataSource = binding;
           // dataGridView1.Columns.Add(new DataGridViewColumn());
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    class Student
    {
        public String name { get; set; }
        public String group { get; set; }
        Dictionary<String, int> marks { get; set; }
    }
}
