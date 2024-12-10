namespace Metodos_de_Busqueda
{
    public partial class Form1 : Form
    {
        private List<int> numbers; // Lista de números
        private HashSet<int> hashSet; // Conjunto Hash para búsqueda hash

        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>();
            hashSet = new HashSet<int>();
        }

        // Generar números aleatorios
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numbers = Enumerable.Range(1, 100).OrderBy(x => rand.Next()).Take(50).ToList();
            hashSet = new HashSet<int>(numbers); // Crear hashSet basado en la lista

            txtNumbers.Text = string.Join(", ", numbers);
            lblResult.Text = "Lista generada con éxito.";
        }

        // Búsqueda Secuencial
        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int target))
            {
                bool found = numbers.Contains(target);
                lblResult.Text = found ? $"Número {target} encontrado (Secuencial)." : "Número no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        // Búsqueda Binaria
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Count == 0)
            {
                MessageBox.Show("Primero genera la lista.");
                return;
            }

            if (int.TryParse(txtSearch.Text, out int target))
            {
                numbers.Sort(); // Ordenar la lista para búsqueda binaria
                int index = numbers.BinarySearch(target);
                lblResult.Text = index >= 0 ? $"Número {target} encontrado (Binaria)." : "Número no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        // Búsqueda Hash
        private void btnHashSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int target))
            {
                bool found = hashSet.Contains(target);
                lblResult.Text = found ? $"Número {target} encontrado (Hash)." : "Número no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }
    }
}
