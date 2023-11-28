using TodoApp.Models;

namespace TodoApp.WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new TodoRepositoryJson("C:\\Temp\\Todos.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tBTitle.Text;
            bool isDone = cBIsDone.Checked;
            Todo todo = new Todo { Title = title, IsDone = isDone } ;
            _repository.Add(todo);
            tBTitle.Text = "";
            cBIsDone.Checked = false;
            DisplayData();
        }
    }
}
