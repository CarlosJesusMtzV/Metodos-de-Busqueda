namespace Metodos_de_Busqueda
{
    public partial class Form1 : Form
    {
        private List<int> numbers; // Lista de n�meros
        private HashSet<int> hashSet; // Conjunto Hash para b�squeda hash

        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>();
            hashSet = new HashSet<int>();
        }

        // Generar n�meros aleatorios
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numbers = Enumerable.Range(1, 100).OrderBy(x => rand.Next()).Take(50).ToList();
            hashSet = new HashSet<int>(numbers); // Crear hashSet basado en la lista

            txtNumbers.Text = string.Join(", ", numbers);
            lblResult.Text = "Lista generada con �xito.";
        }

        // B�squeda Secuencial
        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int target))
            {
                bool found = numbers.Contains(target);
                lblResult.Text = found ? $"N�mero {target} encontrado (Secuencial)." : "N�mero no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un n�mero v�lido.");
            }
        }

        // B�squeda Binaria
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Count == 0)
            {
                MessageBox.Show("Primero genera la lista.");
                return;
            }

            if (int.TryParse(txtSearch.Text, out int target))
            {
                numbers.Sort(); // Ordenar la lista para b�squeda binaria
                int index = numbers.BinarySearch(target);
                lblResult.Text = index >= 0 ? $"N�mero {target} encontrado (Binaria)." : "N�mero no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un n�mero v�lido.");
            }
        }

        // B�squeda Hash
        private void btnHashSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int target))
            {
                bool found = hashSet.Contains(target);
                lblResult.Text = found ? $"N�mero {target} encontrado (Hash)." : "N�mero no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un n�mero v�lido.");
            }
        }
    }
}
