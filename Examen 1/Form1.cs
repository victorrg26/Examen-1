namespace Examen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dtv1.Rows.Clear();

            var resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;
                string contenido = File.ReadAllText(ruta);
                string[] lineas = contenido.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

               
                dtv1.Columns.Clear();

                
                if (lineas.Length > 0)
                {
                    string[] encabezados = lineas[0].Split(',');

                  
                    dtv1.Columns.Add("RFC", "RFC");
                    dtv1.Columns.Add("Promedio", "Promedio");
                    dtv1.Columns.Add("Edad", "Edad");
                    dtv1.Columns.Add("Sexo", "Sexo");

                 
                    for (int i = 0; i < encabezados.Length; i++)
                    {
                        if (encabezados[i] != "RFC" && encabezados[i] != "Promedio")
                        {
                            dtv1.Columns.Add(encabezados[i].Trim(), encabezados[i].Trim());
                        }
                    }

                  
                    for (int i = 1; i < lineas.Length; i++)
                    {
                        string[] valores = lineas[i].Split(',');

                      
                        if (valores.Length == encabezados.Length)
                        {
                            string rfc = valores[0].Trim();
                            string promedio = valores[1].Trim();

                            int edad = CalcularEdad(rfc);
                            string sexo = DeterminarSexo(rfc);

                            string[] fila = new string[dtv1.Columns.Count];
                            fila[0] = rfc; 
                            fila[1] = promedio; 
                            fila[2] = edad.ToString(); 
                            fila[3] = sexo; 

                            for (int j = 2; j < valores.Length; j++)
                            {
                                fila[j + 2] = valores[j].Trim();
                            }

                            
                            dtv1.Rows.Add(fila);
                        }
                    }
                }
            }
        }

        private int CalcularEdad(string curp)
        {
         
            int año = int.Parse(curp.Substring(4, 2));
            int mes = int.Parse(curp.Substring(6, 2));
            int dia = int.Parse(curp.Substring(8, 2));

            
            año += (año >= 30) ? 1900 : 2000;
            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

        
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        private string DeterminarSexo(string curp)
        {
          
            char sexoChar = curp[10];

            if (sexoChar == 'H')
                return "Masculino";
            else if (sexoChar == 'M')
                return "Femenino";
            else
                return "Desconocido";
        }
    }
}