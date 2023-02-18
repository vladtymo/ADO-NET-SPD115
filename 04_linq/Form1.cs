using System.Linq;

namespace _04_linq
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();

            numbers.AddRange(new[]
            {
                1,5,72,0,-1,21,-5,4,0,2,5,61,4,-5,36,48,20,1249,43,24,2434,2
            });

            numberList.DataSource = numbers;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private void FilterEvenClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.Where(IsEven).ToList();
        }

        private void FilterNegativeClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            //numberList.DataSource = numbers.Where(delegate(int num) { return num < 0; }).ToList();
            numberList.DataSource = numbers.Where((num) => num < 0).ToList();
        }

        private void FilterTwoDigitsClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.Where((num) => num >= 10 && num <= 99).ToList();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers;
        }

        private void OrderByAscClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.OrderBy(x => x).ToList();
        }

        private void OrderByDescClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.OrderByDescending(x => x).ToList();
        }

        private void OrderByAbsAscClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.OrderBy(x => Math.Abs(x)).ToList();
        }

        private void CountEvenClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Count of negative values: {numbers.Count(x => x < 0)}");
        }

        private void TopClick(object sender, EventArgs e)
        {
            numberList.DataSource = null;
            numberList.DataSource = numbers.Take((int)topNumeric.Value).ToList();
        }

        private void GroupByClick(object sender, EventArgs e)
        {
            var groups = numbers.GroupBy(x => x % 10); // 123 % 10 = 3

            string result = "Groups:\n";

            foreach (var g in groups)
            {
                result += g.Key + "\n";
                foreach (var item in g)
                {
                    result += $"\t{item}\n";
                }
            }
            MessageBox.Show(result);
        }

        private void FirstClick(object sender, EventArgs e)
        {
            var item = numbers.FirstOrDefault(x => x % 7 == 0 && x != 0);

            if (item == 0) MessageBox.Show("Element not found!");
            else MessageBox.Show($"Found: {item}!");
        }
    }
}