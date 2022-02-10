using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SistemaNonmina
{
    public partial class Home : Form
    {
        Menu pantalla;
        public Home()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-2TMBJAF ; database= PERSONAS2 ; INTEGRATED SECURITY = TRUE");

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dlFicheroCSV = new OpenFileDialog();
            dlFicheroCSV.Title = "Abrir fichero CSV...";
            //dlFicheroCSV.InitialDirectory = @"C:\";
            dlFicheroCSV.Filter = "Ficheros de texto y CSV (*.txt, *.csv)|*.txt;*.csv|" +
                "Ficheros de texto (*.txt)|*.txt|" +
                "Ficheros CSV (*.csv)|*.csv|" +
                "Todos los ficheros (*.*)|*.*";
            dlFicheroCSV.FilterIndex = 1;
            dlFicheroCSV.RestoreDirectory = true;
            if (dlFicheroCSV.ShowDialog() == DialogResult.OK)
            {
                txtFicheroCSV.Text = dlFicheroCSV.FileName;
            }
        }
        private void btLeerCSV_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFicheroCSV.Text))
            {
                try
                {
                    CargarDatosCSV(txtFicheroCSV.Text,
                        Convert.ToChar(txtSeparadorCampos.Text), opTitulos.Checked, txtSeparador.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error al leer CSV...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe el fichero CSV seleccionado.",
                    "Fichero no encontrado...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CargarDatosCSV(string ficheroCSV, char separador, bool primeraLineaTitulo, string separadorCampos)
        {
            dbTabla.DataSource = null;
            dbTabla.Rows.Clear();

            DataTable tablaDatos = new DataTable();
            string[] lineas = File.ReadAllLines(ficheroCSV, Encoding.Default);

            if (lineas.Length > 0)
            {
                //Si la primea línea contiene el título  
                string[] etiquetaTitulosFinal;
                if (primeraLineaTitulo)
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = campoActual;
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {

                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }
                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }
                else
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    int numero = 0;
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = "Dato " + Convert.ToString(numero);
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }

                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                        numero++;
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }

                //Resto de filas de datos
                int inicioFila = 0;
                if (primeraLineaTitulo)
                    inicioFila = 1;
                try
                {
                    int facturas=0;
                    for (int i = inicioFila; i < lineas.Length; i++)
                    {
                        string[] filasDatos = lineas[i].Split(separador);
                        DataRow dataGridS = tablaDatos.NewRow();

                        switch (filasDatos[0])
                        {
                            case "01":
                                insertatabladatoscliente(filasDatos);//funcionasi
                                facturas++;
                                break;
                            case "02":
                                insertatabladatoscliente2(filasDatos);//funciona
                                break;
                            case "02.1":
                                insertatabladatoscliente3(filasDatos);//funcionasi
                                break;
                            case "02.2":
                                insertatabladatoscliente4(filasDatos);//funcionasi
                                break;
                            case "02.3":
                                insertatabladatoscliente5(filasDatos);//funcionasi
                                break;
                            case "03":
                                insertatabladatoscliente6(filasDatos);//funciona
                                break;
                            case "03.1":
                                insertatabladatoscliente7(filasDatos);//funcionasi
                                break;
                            case "03.2":
                                insertatabladatoscliente8(filasDatos);//funcionasi
                                break;
                            case "04":
                                insertatabladatoscliente9(filasDatos);//funcionasi
                                break;
                            case "05":
                                insertatabladatoscliente10(filasDatos);//funcionasi
                                break;
                            case "06":
                                insertatabladatoscliente11(filasDatos);//funcionasi
                                break;
                            case "07":
                                insertatabladatoscliente12(filasDatos);//funcionasi
                                break;
                            case "08":
                                insertatabladatoscliente13(filasDatos);//funcionasi
                                break;
                            case "08.1":
                                insertatabladatoscliente14(filasDatos);//funcionasi
                                break;
                            case "08.2":
                                insertatabladatoscliente15(filasDatos);//funcionasi
                                break;
                            case "08.3":
                                insertatabladatoscliente16(filasDatos);//funcionasi
                                break;
                            case "08.4":
                                insertatabladatoscliente17(filasDatos);//funcionasi
                                break;
                            case "08.5":
                                insertatabladatoscliente18(filasDatos);//funcionasi
                                break;
                            case "09":
                                insertatabladatoscliente19(filasDatos);//funcionasi
                                break;
                            case "09.1":
                                insertatabladatoscliente20(filasDatos);//funcionasi
                                break;
                            case "20":
                                insertatabladatoscliente21(filasDatos);//funciona
                                break;
                            case "20.1":
                                insertatabladatoscliente22(filasDatos);//funciona
                                break;
                            case "20.2":
                                insertatabladatoscliente23(filasDatos);//funciona
                                break;
                            case "21":
                                insertatabladatoscliente24(filasDatos);//funciona
                                break;
                            case "21.1":
                                insertatabladatoscliente25(filasDatos);//funciona
                                break;
                            case "21.2":
                                insertatabladatoscliente26(filasDatos);//funciona
                                break;
                            case "21.3":
                                insertatabladatoscliente27(filasDatos);//funciona
                                break;
                            case "21.4":
                                insertatabladatoscliente28(filasDatos);//funciona
                                break;
                            case "22":
                                insertatabladatoscliente29(filasDatos);//funciona
                                break;
                            case "23":
                                insertatabladatoscliente30(filasDatos);//funciona
                                break;
                            case "24":
                                insertatabladatoscliente31(filasDatos);//funciona
                                break;
                            case "25":
                                insertatabladatoscliente32(filasDatos);//funciona
                                break;
                            case "26":
                                insertatabladatoscliente33(filasDatos);//funciona
                                break;
                            case "50":
                                insertatabladatoscliente34(filasDatos);//funciona
                                break;
                            case "90":
                                insertatabladatoscliente35(filasDatos);//funciona
                                break;
                            case "99":
                                insertatabladatoscliente36(filasDatos);//funciona
                                break;


                        }
                        




                        int columnIndex = 0;
                        foreach (string campoActual in etiquetaTitulosFinal)
                        {

                            try
                            {


                                string valor = filasDatos[columnIndex++];
                                // Quitamos el posible carácter de inicio y fin de valor
                                if (separadorCampos != "")
                                {

                                    valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                                    valor = valor.TrimStart(Convert.ToChar(separadorCampos));

                                }
                                dataGridS[campoActual] = valor;
                            }
                            catch
                            {
                                dataGridS[campoActual] = "";

                            }
                        }
                        tablaDatos.Rows.Add(dataGridS);


                    }
                    MessageBox.Show("Se insertaron "+facturas+" facturas");
                }
                catch(Exception e)
                {
                    MessageBox.Show("Los datos no se cargaron a la base de datos "+e);
                }
            }
            if (tablaDatos.Rows.Count > 0)
            {
                dbTabla.DataSource = tablaDatos;
            }
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            pantalla = new Menu();
            pantalla.Show();
            this.Hide();
        }
        private void insertatabladatoscliente36(string[] filasDatos)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_36_Datos_adicionales_a_la_factura (Campo01,Campo02,Campo03,Campo04,Campo05,Campo06,Campo07,Campo08,Campo08,Campo10,Campo11,Campo12,Campo13,Campo14,Campo15,Campo16,Campo17,Campo18,Campo19,Campo20,Campo21,Campo22,Campo23,Campo24,Campo25,Campo26,Campo27,Campo28,Campo29,Campo30) VALUES (@Campo01,@Campo02,@Campo03,@Campo04,@Campo05,@Campo06,@Campo07,@Campo08,@Campo08,@Campo10,@Campo11,@Campo12,@Campo13,@Campo14,@Campo15,@Campo16,@Campo17,@Campo18,@Campo19,@Campo20,@Campo21,@Campo22,@Campo23,@Campo24,@Campo25,@Campo26,@Campo27,@Campo28,@Campo29,@Campo30)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("Campo01", filasDatos[1]);
                agregar.Parameters.AddWithValue("Campo02", filasDatos[2]);
                agregar.Parameters.AddWithValue("Campo03", filasDatos[3]);
                agregar.Parameters.AddWithValue("Campo04", filasDatos[4]);
                agregar.Parameters.AddWithValue("Campo05", filasDatos[5]);
                agregar.Parameters.AddWithValue("Campo06", filasDatos[6]);
                agregar.Parameters.AddWithValue("Campo07", filasDatos[7]);
                agregar.Parameters.AddWithValue("Campo08", filasDatos[8]);
                agregar.Parameters.AddWithValue("Campo09", filasDatos[9]);
                agregar.Parameters.AddWithValue("Campo10", filasDatos[10]);
                agregar.Parameters.AddWithValue("Campo11", filasDatos[11]);
                agregar.Parameters.AddWithValue("Campo12", filasDatos[12]);
                agregar.Parameters.AddWithValue("Campo13", filasDatos[13]);
                agregar.Parameters.AddWithValue("Campo14", filasDatos[14]);
                agregar.Parameters.AddWithValue("Campo15", filasDatos[15]);
                agregar.Parameters.AddWithValue("Campo16", filasDatos[16]);
                agregar.Parameters.AddWithValue("Campo17", filasDatos[17]);
                agregar.Parameters.AddWithValue("Campo18", filasDatos[18]);
                agregar.Parameters.AddWithValue("Campo19", filasDatos[19]);
                agregar.Parameters.AddWithValue("Campo20", filasDatos[20]);
                agregar.Parameters.AddWithValue("Campo21", filasDatos[21]);
                agregar.Parameters.AddWithValue("Campo22", filasDatos[22]);
                agregar.Parameters.AddWithValue("Campo23", filasDatos[23]);
                agregar.Parameters.AddWithValue("Campo24", filasDatos[24]);
                agregar.Parameters.AddWithValue("Campo25", filasDatos[25]);
                agregar.Parameters.AddWithValue("Campo26", filasDatos[26]);
                agregar.Parameters.AddWithValue("Campo27", filasDatos[27]);
                agregar.Parameters.AddWithValue("Campo28", filasDatos[28]);
                agregar.Parameters.AddWithValue("Campo29", filasDatos[29]);
                agregar.Parameters.AddWithValue("Campo30", filasDatos[30]);



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente35(string[] filasDatos)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_35_Datos_del_domicilio_de_emision (Calle,No_exterior,No_Interior,Colonia,Localidad,Municipio,CP,Estado,Pais,Referencia) VALUES (@Calle,@No_exterior,@No_Interior,@Colonia,@Localidad,@Municipio,@CP,@Estado,@Pais,@Referencia)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Calle", filasDatos[1]);
                agregar.Parameters.AddWithValue("@No_exterior", filasDatos[2]);
                agregar.Parameters.AddWithValue("@No_Interior", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Colonia", filasDatos[4]);
                agregar.Parameters.AddWithValue("@Localidad", filasDatos[5]);
                agregar.Parameters.AddWithValue("@Municipio", filasDatos[6]);
                agregar.Parameters.AddWithValue("@CP", filasDatos[7]);
                agregar.Parameters.AddWithValue("@Estado", filasDatos[8]);
                agregar.Parameters.AddWithValue("@Pais", filasDatos[9]);
                agregar.Parameters.AddWithValue("@Referencia", filasDatos[10]);



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente34(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_34_Informacion_de_recibos_referenciados_por_emision_de_nota_de_credito (Numero_de_recibo) VALUES (@Numero_de_recibo)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Numero_de_recibo", filasDatos[1]);



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente33(string[] filasDatos)
        {
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0.00";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0";
            }
            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_33_Informacion_para_impuestos_locales_traslados (Descripcion_del_impuesto,Tasa,Importe) VALUES (@Descripcion_del_impuesto,@Tasa,@Importe)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Descripcion_del_impuesto", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Tasa", Decimal.Parse(filasDatos[2]));
                agregar.Parameters.AddWithValue("@Importe", Decimal.Parse(filasDatos[3]));



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente32(string[] filasDatos)
        {
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0.00";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0";
            }
            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_32_Informacion_para_impuestos_locales_retenidos (Descripcion_del_impuesto,Tasa,Importe) VALUES (@Descripcion_del_impuesto,@Tasa,@Importe)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Descripcion_del_impuesto", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Tasa", Decimal.Parse(filasDatos[2]));
                agregar.Parameters.AddWithValue("@Importe", Decimal.Parse(filasDatos[3]));




                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente31(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0";
            }
            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            for (int i = 0; i <= 4; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_31_Informacion_para_horas_extras_laboradas (Dias_de_trabajo,Tipo_de_horas,Horas,Importe) VALUES (@Dias_de_trabajo,@Tipo_de_horas,@Horas,@Importe)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Dias_de_trabajo", Int32.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Tipo_de_horas", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Horas", Int32.Parse(filasDatos[3]));
                agregar.Parameters.AddWithValue("@Importe", Decimal.Parse(filasDatos[3]));




                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente30(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0.00";
            }
            for (int i = 0; i <= 3; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_30_Informacion_para_incapacidades_del_trabajador (Dias_de_incapacidad,Tipo_de_incapacidad,Importe_Monetario_del_descuento) VALUES (@Dias_de_incapacidad,@Tipo_de_incapacidad,@Importe_Monetario_del_descuento)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Dias_de_incapacidad", Int32.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Tipo_de_incapacidad", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Importe_Monetario_del_descuento", Decimal.Parse(filasDatos[3]));




                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente29(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0.00";
            }
            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            for (int i = 0; i <= 5; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_29_Conceptos_de_duducciones_por_nomina (Tipo_de_deduccion,Codigo_de_deduccion,Descripcion,Importe,Vacio) VALUES (@Tipo_de_deduccion,@Codigo_de_deduccion,@Descripcion,@Importe,@Vacio)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Tipo_de_deduccion", Int32.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Codigo_de_deduccion", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Descripcion", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Importe", Decimal.Parse(filasDatos[4]));
                agregar.Parameters.AddWithValue("@Vacio", filasDatos[5]);



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente28(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0.00";
            }
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0.00";
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_28_Informacion_de_percepciones_por_acciones_o_titulos (Valor_del_mercado,Precio_al_otorgarse) VALUES (@Valor_del_mercado,@Precio_al_otorgarse)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Valor_del_mercado", Decimal.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Precio_al_otorgarse", Decimal.Parse(filasDatos[2]));



                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente27(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0.00";
            }
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0.00";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0.00";
            }
            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_27_Informacion_de_jubilacion_pension_y_retiro (Total_una_exhibicion,Total_parcialidad,Monto_diario,Ingreso_acumulable,Ingresi_no_acumulable) VALUES (@Total_una_exhibicion,@Total_parcialidad,@Monto_diario,@Ingreso_acumulable,@Ingresi_no_acumulable)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Total_una_exhibicion", Decimal.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Total_parcialidad", Decimal.Parse(filasDatos[2]));
                agregar.Parameters.AddWithValue("@Monto_diario", Decimal.Parse(filasDatos[3]));
                agregar.Parameters.AddWithValue("@Ingreso_acumulable", Decimal.Parse(filasDatos[4]));
                agregar.Parameters.AddWithValue("@Ingresi_no_acumulable", Decimal.Parse(filasDatos[5]));


                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente26(string[] filasDatos)
        {


            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0.00";
            }
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0";
            }
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0.00";
            }
            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }

            for (int i = 1; i <= 5; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }

            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_26_Informacion_de_separacion_por_indemnizacion (Total_pagado,Numero_de_año_de_servicios,Ultimo_sueldo_mensual_ordinario,Ingreso_acumulable,Ingreso_no_acumulable) VALUES (@Total_pagado,@Numero_de_año_de_servicios,@Ultimo_sueldo_mensual_ordinario,@Ingreso_acumulable,@Ingreso_no_acumulable)", conexion);


            try
            {


                agregar.Parameters.AddWithValue("@Total_pagado", Decimal.Parse(filasDatos[1]));
                agregar.Parameters.AddWithValue("@Numero_de_año_de_servicios", Int32.Parse(filasDatos[2]));
                agregar.Parameters.AddWithValue("@Ultimo_sueldo_mensual_ordinario", Decimal.Parse(filasDatos[3]));
                agregar.Parameters.AddWithValue("@Ingreso_acumulable", Decimal.Parse(filasDatos[4]));
                agregar.Parameters.AddWithValue("@Ingreso_no_acumulable", Decimal.Parse(filasDatos[5]));


                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente25(string[] filasDatos)
        {

            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales (Tipo_de_otro_pago,Clave_del_patron,Concepto_de_otro_pago,Importe_otro_pago,Subsidio_al_empleo_causado,Saldo_a_favor,Año_saldo_a_favor,Remanente_saldo_a_favor) VALUES (@Tipo_de_otro_pago,@Clave_del_patron,@Concepto_de_otro_pago,@Importe_otro_pago,@Subsidio_al_empleo_causado,@Saldo_a_favor,@Año_saldo_a_favor,@Remanente_saldo_a_favor)", conexion);

            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }
            if (filasDatos[6] == "")
            {
                filasDatos[6] = "0.00";
            }
            if (filasDatos[8] == "")
            {
                filasDatos[8] = "0.00";
            }

            for (int i = 1; i == 8; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }




            try
            {


                agregar.Parameters.AddWithValue("@Tipo_de_otro_pago", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Clave_del_patron", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Concepto_de_otro_pago", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Importe_otro_pago", Decimal.Parse(filasDatos[4]));
                agregar.Parameters.AddWithValue("@Subsidio_al_empleo_causado", Decimal.Parse(filasDatos[5]));
                agregar.Parameters.AddWithValue("@Saldo_a_favor", Decimal.Parse(filasDatos[6]));
                agregar.Parameters.AddWithValue("@Año_saldo_a_favor", filasDatos[7]);
                agregar.Parameters.AddWithValue("@Remanente_saldo_a_favor", Decimal.Parse(filasDatos[8]));

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }


        }
        private void insertatabladatoscliente24(string[] filasDatos)
        {

            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_24_Conceptos_de_percepciones_por_nomina (Tipo_de_percepcion,Clave_de_percepcion,Descripcion,Importe_gravado,Importe_exento) VALUES (@Tipo_de_percepcion,@Clave_de_percepcion,@Descripcion,@Importe_gravado,@Importe_exento)", conexion);


            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0";
            }


            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }
            for (int i = 0; i == 5; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }
            agregar.Parameters.AddWithValue("@Tipo_de_percepcion", Convert.ToInt32(filasDatos[1]));
            agregar.Parameters.AddWithValue("@Clave_de_percepcion", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Descripcion", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Importe_gravado", Convert.ToDecimal(filasDatos[4]));
            agregar.Parameters.AddWithValue("@Importe_exento", Convert.ToDecimal(filasDatos[5]));



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente23(string[] filasDatos)
        {

            SqlCommand agregar = new SqlCommand("INSERT INTO Informacion_de_datos_de_subcontratacion_del_empleo (Rfc_subcontratador,Porcentaje_de_tiempo) VALUES (@Rfc_subcontratador,@Porcentaje_de_tiempo)", conexion);


            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }
            if (filasDatos[2] == "")
            {
                filasDatos[2] = " ";
            }
            agregar.Parameters.AddWithValue("@Rfc_subcontratador", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Porcentaje_de_tiempo", filasDatos[2]);



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente22(string[] filasDatos)
        {

            SqlCommand agregar = new SqlCommand("INSERT INTO Informacion_para_emision_de_cfdi_nomina_para_entidades_adheridas_al_sistema_nacional_de_coordinacion_fiscal (Origen_del_recurso) VALUES (@Origen_del_recurso)", conexion);


            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }
            agregar.Parameters.AddWithValue("@Origen_del_recurso", filasDatos[1]);



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente21(string[] filasDatos)
        {



            try
            {

                for (int i = 6; i <= 8; i++)
                {
                    if (filasDatos[i] == "")
                    {
                        filasDatos[i] = "0000/00/00 00:00:00";
                    }
                    String.Format("{0:yyyy/M/d HH:mm:ss}", filasDatos[i]);

                }
                if (filasDatos[13] == "")
                {
                    filasDatos[13] = "0000/00/00 00:00:00";
                    String.Format("{0:yyyy/M/d HH:mm:ss}", filasDatos[2]);
                }


                if (filasDatos[9] == "")
                {
                    filasDatos[9] = "0.00";
                }
                if (filasDatos[19] == "")
                {
                    filasDatos[19] = "0.00";
                }
                for (int i = 21; i <= 25; i++)
                {
                    if (filasDatos[i] == "")
                    {
                        filasDatos[i] = "0.00";
                    }
                }
                for (int i = 27; i <= 32; i++)
                {
                    if (filasDatos[i] == "")
                    {
                        filasDatos[i] = "0.00";
                    }
                }

                for (int i = 0; i <= 36; i++)
                {
                    if (filasDatos[i] == "")
                    {
                        filasDatos[i] = " ";
                    }
                }



                SqlCommand agregar = new SqlCommand("INSERT INTO TBL_21_Informacion_para_emision_de_cfdi_nomina (Registro_patronal,Numero_de_empleado,Clave_curp,Tipo_de_regimen,Numero_de_seguridad_social,Fecha_de_pago,Fecha_inicial_de_pago,Fecha_final_de_pago,Dias_pagados,Nobre_departamento,Cuenta_bancaria,Clave_banco,Fecha_laboral_de_inicio,Antiguedad,Puesto,Tipo_de_contrato,Tipo_de_jornada,Periodicidad_del_pago,Salario_base_cotizacion_por_aportaciones,Riesgo_del_puesto,Salario_diario_integrado,Total_de_percepciones_gravadas,Total_de_percepciones_excentas,Total_de_otras_deducciones,Total_de_impuestos_retenidos,Tipo_de_nomina,Total_de_percepciones,Total_de_sueldos,Total_de_conceptos_por_separacion_e_indemnizacion,Total_de_conceptos_por_jubilacion_pension_retiro,Total_de_deducciones,Total_otros_pagos,Curp_del_emisor,Rfc_patron_origen,Trabajados_sindicalizado,Clave_de_entidad_federativa) VALUES (@Registro_patronal,@Numero_de_empleado,@Clave_curp,@Tipo_de_regimen,@Numero_de_seguridad_social,@Fecha_de_pago,@Fecha_inicial_de_pago,@Fecha_final_de_pago,@Dias_pagados,@Nobre_departamento,@Cuenta_bancaria,@Clave_banco,@Fecha_laboral_de_inicio,@Antiguedad,@Puesto,@Tipo_de_contrato,@Tipo_de_jornada,@Periodicidad_del_pago,@Salario_base_cotizacion_por_aportaciones,@Riesgo_del_puesto,@Salario_diario_integrado,@Total_de_percepciones_gravadas,@Total_de_percepciones_excentas,@Total_de_otras_deducciones,@Total_de_impuestos_retenidos,@Tipo_de_nomina,@Total_de_percepciones,@Total_de_sueldos,@Total_de_conceptos_por_separacion_e_indemnizacion,@Total_de_conceptos_por_jubilacion_pension_retiro,@Total_de_deducciones,@Total_otros_pagos,@Curp_del_emisor,@Rfc_patron_origen,@Trabajados_sindicalizado,@Clave_de_entidad_federativa)", conexion);


                agregar.Parameters.AddWithValue("@Registro_patronal", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Numero_de_empleado", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Clave_curp", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Tipo_de_regimen", filasDatos[4]);
                agregar.Parameters.AddWithValue("@Numero_de_seguridad_social", filasDatos[5]);
                agregar.Parameters.AddWithValue("@Fecha_de_pago", Convert.ToDateTime(filasDatos[6]));
                agregar.Parameters.AddWithValue("@Fecha_inicial_de_pago", Convert.ToDateTime(filasDatos[7]));
                agregar.Parameters.AddWithValue("@Fecha_final_de_pago", Convert.ToDateTime(filasDatos[8]));
                agregar.Parameters.AddWithValue("@Dias_pagados", Convert.ToDecimal(filasDatos[9]));
                agregar.Parameters.AddWithValue("@Nobre_departamento", filasDatos[10]);
                agregar.Parameters.AddWithValue("@Cuenta_bancaria", filasDatos[11]);
                agregar.Parameters.AddWithValue("@Clave_banco", filasDatos[12]);
                agregar.Parameters.AddWithValue("@Fecha_laboral_de_inicio", Convert.ToDateTime(filasDatos[13]));
                agregar.Parameters.AddWithValue("@Antiguedad", filasDatos[14]);
                agregar.Parameters.AddWithValue("@Puesto", filasDatos[15]);
                agregar.Parameters.AddWithValue("@Tipo_de_contrato", filasDatos[16]);
                agregar.Parameters.AddWithValue("@Tipo_de_jornada", filasDatos[17]);
                agregar.Parameters.AddWithValue("@Periodicidad_del_pago", filasDatos[18]);
                agregar.Parameters.AddWithValue("@Salario_base_cotizacion_por_aportaciones", Convert.ToDecimal(filasDatos[19]));
                agregar.Parameters.AddWithValue("@Riesgo_del_puesto", filasDatos[20]);
                agregar.Parameters.AddWithValue("@Salario_diario_integrado", Convert.ToDecimal(filasDatos[21]));
                agregar.Parameters.AddWithValue("@Total_de_percepciones_gravadas", Convert.ToDecimal(filasDatos[22]));
                agregar.Parameters.AddWithValue("@Total_de_percepciones_excentas", Convert.ToDecimal(filasDatos[23]));
                agregar.Parameters.AddWithValue("@Total_de_otras_deducciones", Convert.ToDecimal(filasDatos[24]));
                agregar.Parameters.AddWithValue("@Total_de_impuestos_retenidos", Convert.ToDecimal(filasDatos[25]));
                agregar.Parameters.AddWithValue("@Tipo_de_nomina", filasDatos[26]);
                agregar.Parameters.AddWithValue("@Total_de_percepciones", Convert.ToDecimal(filasDatos[27]));
                agregar.Parameters.AddWithValue("@Total_de_sueldos", Convert.ToDecimal(filasDatos[28]));
                agregar.Parameters.AddWithValue("@Total_de_conceptos_por_separacion_e_indemnizacion", Convert.ToDecimal(filasDatos[29]));
                agregar.Parameters.AddWithValue("@Total_de_conceptos_por_jubilacion_pension_retiro", Convert.ToDecimal(filasDatos[30]));
                agregar.Parameters.AddWithValue("@Total_de_deducciones", Convert.ToDecimal(filasDatos[31]));
                agregar.Parameters.AddWithValue("@Total_otros_pagos", Convert.ToDecimal(filasDatos[32]));
                agregar.Parameters.AddWithValue("@Curp_del_emisor", filasDatos[33]);
                agregar.Parameters.AddWithValue("@Rfc_patron_origen", filasDatos[34]);
                agregar.Parameters.AddWithValue("@Trabajados_sindicalizado", filasDatos[35]);
                agregar.Parameters.AddWithValue("@Clave_de_entidad_federativa", filasDatos[36]);

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente20(string[] filasDatos)
        {
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }
            if (filasDatos[8] == "")
            {
                filasDatos[8] = "0.00";
            }
            if (filasDatos[9] == "")
            {
                filasDatos[9] = "0.00";
            }
            if (filasDatos[10] == "")
            {
                filasDatos[10] = "0.00";
            }


            for (int i = 0; i <= 10; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO Documentos_relacionados_para_el_complemento_de_pagos (Id_documento_relacionado,Serie,Folio,Moneda,Tipo_de_cambio,Metodo_de_pago,Numero_de_parcialidad,Importe_saldo_anterior,Importe_pagado,Importe_saldo_insoluto) VALUES (@Id_documento_relacionado,@Serie,@Folio,@Moneda,@Tipo_de_cambio,@Metodo_de_pago,@Numero_de_parcialidad,@Importe_saldo_anterior,@Importe_pagado,@Importe_saldo_insoluto)", conexion);

            agregar.Parameters.AddWithValue("@Id_documento_relacionado", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Serie", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Folio", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Moneda", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Tipo_de_cambio", Convert.ToDecimal(filasDatos[5]));
            agregar.Parameters.AddWithValue("@Metodo_de_pago", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Numero_de_parcialidad", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Importe_saldo_anterior", Convert.ToDecimal(filasDatos[8]));
            agregar.Parameters.AddWithValue("@Importe_pagado", Convert.ToDecimal(filasDatos[9]));
            agregar.Parameters.AddWithValue("@Importe_saldo_insoluto", Convert.ToDecimal(filasDatos[10]));



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }

        }
        private void insertatabladatoscliente19(string[] filasDatos)
        {
            if (filasDatos[2] == "")
            {
                filasDatos[2] = "0000/00/00 00:00:00";
                String.Format("{0:yyyy/M/d HH:mm:ss}", filasDatos[2]);
            }

            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }
            if (filasDatos[6] == "")
            {
                filasDatos[6] = "0.00";
            }


            for (int i = 0; i <= 11; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO Complementos_de_pago (Fecha_de_pago,Forma_de_pago,Moneda,Tipo_de_cambio,Monto_del_pago,No_de_operacion,Rfc_emisor_cuenta_ordenante,Nombre_banco_ordenante_extranjero,Cuenta_ordenante,Rfc_emisor_cuenta_beneficiario,Cuenta_beneficiario,Tipo_de_cadena_de_pago,Certificado_del_pago,Cadena_original_de_pago,Sello_digital_del_pago) VALUES (@Fecha_de_pago,@Forma_de_pago,@Moneda,@Tipo_de_cambio,@Monto_del_pago,@No_de_operacion,@Rfc_emisor_cuenta_ordenante,@Nombre_banco_ordenante_extranjero,@Cuenta_ordenante,@Rfc_emisor_cuenta_beneficiario,@Cuenta_beneficiario,@Tipo_de_cadena_de_pago,@Certificado_del_pago,@Cadena_original_de_pago,@Sello_digital_del_pago)", conexion);




            agregar.Parameters.AddWithValue("@Fecha_de_pago", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Forma_de_pago", Convert.ToDateTime(filasDatos[2]));
            agregar.Parameters.AddWithValue("@Moneda", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Tipo_de_cambio", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Monto_del_pago", Convert.ToDecimal(filasDatos[5]));
            agregar.Parameters.AddWithValue("@No_de_operacion", Convert.ToDecimal(filasDatos[6]));
            agregar.Parameters.AddWithValue("@Rfc_emisor_cuenta_ordenante", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Nombre_banco_ordenante_extranjero", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Cuenta_ordenante", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Rfc_emisor_cuenta_beneficiario", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Cuenta_beneficiario", filasDatos[11]);
            agregar.Parameters.AddWithValue("@Tipo_de_cadena_de_pago", filasDatos[12]);
            agregar.Parameters.AddWithValue("@Certificado_del_pago", filasDatos[13]);
            agregar.Parameters.AddWithValue("@Cadena_original_de_pago", filasDatos[14]);
            agregar.Parameters.AddWithValue("@Sello_digital_del_pago", filasDatos[15]);




            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente18(string[] filasDatos)
        {
            if (filasDatos[3] == "")
            {
                filasDatos[3] = "0.00";
            }

            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }
            if (filasDatos[6] == "")
            {
                filasDatos[6] = "0.00";
            }


            for (int i = 0; i <= 11; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1 (No_identificacion,Fraccion_arancelaria,Cantidad_en_aduana,Unidad_de_Medida_aduana,Valor_unitario,Valor_en_dolares,Marca,Modelo,SubModelo,No_serie) VALUES (@No_identificacion,@Fraccion_arancelaria,@Cantidad_en_aduana,@Unidad_de_Medida_aduana,@Valor_unitario,@Valor_en_dolares,@Marca,@Modelo,@SubModelo,@No_serie)", conexion);


            agregar.Parameters.AddWithValue("@No_identificacion", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Fraccion_arancelaria", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Cantidad_en_aduana", Convert.ToDecimal(filasDatos[3]));
            agregar.Parameters.AddWithValue("@Unidad_de_Medida_aduana", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Valor_unitario", Convert.ToDecimal(filasDatos[5]));
            agregar.Parameters.AddWithValue("@Valor_en_dolares", Convert.ToDecimal(filasDatos[6]));
            agregar.Parameters.AddWithValue("@Marca", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Modelo", filasDatos[8]);
            agregar.Parameters.AddWithValue("@SubModelo", filasDatos[9]);
            agregar.Parameters.AddWithValue("@No_serie", filasDatos[10]);



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente17(string[] filasDatos)
        {
            for (int i = 0; i <= 12; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1 (No_registro_fiscal,Nombre,Calle,No_exterior,No_interior,Colonia,Localidad,Referencia,Municipio,Estado,Pais,Codigo_postal) VALUES (@No_registro_fiscal,@Nombre,@Calle,@No_exterior,@No_interior,@Colonia,@Localidad,@Referencia,@Municipio,@Estado,@Pais,@Codigo_postal)", conexion);


            agregar.Parameters.AddWithValue("@No_registro_fiscal", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Nobre", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Calle", filasDatos[3]);
            agregar.Parameters.AddWithValue("@No_exterior", filasDatos[4]);
            agregar.Parameters.AddWithValue("@No_interior", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Colonia", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Localidad", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Referencia", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Municipio", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Estado", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Pais", filasDatos[11]);
            agregar.Parameters.AddWithValue("@Codigo_postal", filasDatos[12]);

            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente16(string[] filasDatos)
        {

            for (int i = 0; i <= 11; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1 (No_registro_fiscal,Calle,No_exterior,No_interior,Colonia,Localidad,Referencia,Municipio,Estado,Pais,Codigo_postal) VALUES (@No_registro_fiscal,@Calle,@No_exterior,@No_interior,@Colonia,@Localidad,@Referencia,@Municipio,@Estado,@Pais,@Codigo_postal)", conexion);


            agregar.Parameters.AddWithValue("@No_registro_fiscal", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Calle", filasDatos[2]);
            agregar.Parameters.AddWithValue("@No_exterior", filasDatos[3]);
            agregar.Parameters.AddWithValue("@No_interior", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Colonia", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Localidad", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Referencia", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Municipio", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Estado", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Pais", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Codigo_postal", filasDatos[11]);

            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente15(string[] filasDatos)
        {



            for (int i = 0; i <= 2; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_15_Datos_complementarios_del_propietario_de_las_mercancias_en_el_caso_de_cfdi_con_complementos_de_comercio_exterior (No_registro_fiscal,Residencia_fiscal) VALUES (@No_registro_fiscal,@Residencia_fiscal)", conexion);


            agregar.Parameters.AddWithValue("@No_registro_fiscal", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Residencia_fiscal", filasDatos[2]);

            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente14(string[] filasDatos)
        {

            for (int i = 0; i <= 11; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_14_Informacion_adicional_del_producto (Curp,Calle,No_exterior,No_interior,Colonia,Localidad,Referencia,Municipio,Estado,Pais,Codigo_postal) VALUES (@Curp,@Calle,@No_exterior,@No_interior,@Colonia,@Localidad,@Referencia,@Municipio,@Estado,@Pais,@Codigo_postal)", conexion);


            agregar.Parameters.AddWithValue("@Curp", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Calle", filasDatos[2]);
            agregar.Parameters.AddWithValue("@No_exterior", filasDatos[3]);
            agregar.Parameters.AddWithValue("@No_interior", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Colonia", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Localidad", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Referencia", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Municipio", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Estado", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Pais", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Codigo_postal", filasDatos[11]);

            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente13(string[] filasDatos)
        {

            if (filasDatos[10] == "")
            {
                filasDatos[10] = "0.00";
            }

            if (filasDatos[11] == "")
            {
                filasDatos[11] = "0.00";
            }
            for (int i = 0; i <= 11; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT TBL_13_INTO Informacion_adicional_del_producto (Motivo_de_traslado,TipoOperecion,Clave_de_pedimento,Certificado_origen,Numero_de_certificado_de_origen,Numero_de_exportador_confiable,No_incoterm,Subdivision,Observacion,Tipo_de_cambio_usd,Monto_en_dolares) VALUES (@Motivo_de_traslado,@TipoOperecion,@Clave_de_pedimento,@Certificado_origen,@Numero_de_certificado_de_origen,@Numero_de_exportador_confiable,@No_incoterm,@Subdivision,@Observacion,@Tipo_de_cambio_usd,@Monto_en_dolares)", conexion);

            agregar.Parameters.AddWithValue("@Motivo_de_traslado", filasDatos[1]);
            agregar.Parameters.AddWithValue("@TipoOperecion", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Clave_de_pedimento", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Certificado_origen", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Numero_de_certificado_de_origen", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Numero_de_exportador_confiable", filasDatos[6]);
            agregar.Parameters.AddWithValue("@No_incoterm", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Subdivision", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Observacion", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Tipo_de_cambio_usd", Convert.ToDecimal(filasDatos[10]));
            agregar.Parameters.AddWithValue("@Monto_en_dolares", Convert.ToDecimal(filasDatos[11]));



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente12(string[] filasDatos)
        {
            for (int i = 0; i <= 41; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_12_Informacion_adicional_del_producto (Costo,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Impuesto1,Montoimpuesto1,Porcentajeimpuesto1,Impuesto2,Montoimpuesto2,Porcentajeimpuesto2,Impuesto3,Montoimpuesto3,Porcentajeimpuesto3,Impuesto4,Montoimpuesto4,Porcentajeimpuesto4,Impuesto5,Montoimpuesto5,Porcentajeimpuesto5,Peso,Volumen,Cajas,Paisorigen,Ordencompra,Adicional1,Adicional2,Adicional3,Adicional4,Adicional5,Montoadicional1,Montoadicional2,Montoadicional3,Montoadicional4,Montoadicional5,Montoadicional6,Montoadicional7,Montoadicional8,Montoadicional9,Montoadicional10) VALUES (@Costo,@Codigo1,@Codigo2,@Codigo3,@Codigo4,@Codigo5,@Impuesto1,@Montoimpuesto1,@Porcentajeimpuesto1,@Impuesto2,@Montoimpuesto2,@Porcentajeimpuesto2,@Impuesto3,@Montoimpuesto3,@Porcentajeimpuesto3,@Impuesto4,@Montoimpuesto4,@Porcentajeimpuesto4,@Impuesto5,@Montoimpuesto5,@Porcentajeimpuesto5,@Peso,@Volumen,@Cajas,@Paisorigen,@Ordencompra,@Adicional1,@Adicional2,@Adicional3,@Adicional4,@Adicional5,@Montoadicional1,@Montoadicional2,@Montoadicional3,@Montoadicional4,@Montoadicional5,@Montoadicional6,@Montoadicional7,@Montoadicional8,@Montoadicional9,@Montoadicional10)", conexion);

            agregar.Parameters.AddWithValue("@Costo", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Codigo1", filasDatos[2]);
            agregar.Parameters.AddWithValue("@Codigo2", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Codigo3", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Codigo4", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Codigo5", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Impuesto1", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Montoimpuesto1", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Porcentajeimpuesto1", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Impuesto2", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Montoimpuesto2", filasDatos[11]);
            agregar.Parameters.AddWithValue("@Porcentajeimpuesto2", filasDatos[12]);
            agregar.Parameters.AddWithValue("@Impuesto3", filasDatos[13]);
            agregar.Parameters.AddWithValue("@Montoimpuesto3", filasDatos[14]);
            agregar.Parameters.AddWithValue("@Porcentajeimpuesto3", filasDatos[15]);
            agregar.Parameters.AddWithValue("@Impuesto4", filasDatos[16]);
            agregar.Parameters.AddWithValue("@Montoimpuesto4", filasDatos[17]);
            agregar.Parameters.AddWithValue("@Porcentajeimpuesto4", filasDatos[18]);
            agregar.Parameters.AddWithValue("@Impuesto5", filasDatos[19]);
            agregar.Parameters.AddWithValue("@Montoimpuesto5", filasDatos[20]);
            agregar.Parameters.AddWithValue("@Porcentajeimpuesto5", filasDatos[21]);
            agregar.Parameters.AddWithValue("@Peso", filasDatos[22]);
            agregar.Parameters.AddWithValue("@Volumen", filasDatos[23]);
            agregar.Parameters.AddWithValue("@Cajas", filasDatos[24]);
            agregar.Parameters.AddWithValue("@Paisorigen", filasDatos[25]);
            agregar.Parameters.AddWithValue("@Ordencompra", filasDatos[26]);
            agregar.Parameters.AddWithValue("@Adicional1", filasDatos[27]);
            agregar.Parameters.AddWithValue("@Adicional2", filasDatos[28]);
            agregar.Parameters.AddWithValue("@Adicional3", filasDatos[29]);
            agregar.Parameters.AddWithValue("@Adicional4", filasDatos[30]);
            agregar.Parameters.AddWithValue("@Adicional5", filasDatos[31]);
            agregar.Parameters.AddWithValue("@Montoadicional1", filasDatos[32]);
            agregar.Parameters.AddWithValue("@Montoadicional2", filasDatos[33]);
            agregar.Parameters.AddWithValue("@Montoadicional3", filasDatos[34]);
            agregar.Parameters.AddWithValue("@Montoadicional4", filasDatos[35]);
            agregar.Parameters.AddWithValue("@Montoadicional5", filasDatos[36]);
            agregar.Parameters.AddWithValue("@Montoadicional6", filasDatos[37]);
            agregar.Parameters.AddWithValue("@Montoadicional7", filasDatos[38]);
            agregar.Parameters.AddWithValue("@Montoadicional8", filasDatos[39]);
            agregar.Parameters.AddWithValue("@Montoadicional9", filasDatos[40]);
            agregar.Parameters.AddWithValue("@Montoadicional10", filasDatos[41]);



            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente11(string[] filasDatos)
        {
            if (filasDatos[1] == "")
            {
                filasDatos[1] = "0.00";
            }
            if (filasDatos[5] == "")
            {
                filasDatos[5] = "0.00";
            }

            if (filasDatos[6] == "")
            {
                filasDatos[6] = "0.00";
            }
            for (int i = 0; i <= 10; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera (Cantidad,Unidad_de_medida,No_de_identificacion,Descripcion,Precio_unitario,Importe,Numero_pedimento,Fecha,Aduana,Codigo_de_producto_servicio_sat) VALUES (@Cantidad,@Unidad_de_medida,@No_de_identificacion,@Descripcion,@Precio_unitario,@Importe,@Numero_pedimento,@Fecha,@Aduana,@Codigo_de_producto_servicio_sat)", conexion);




            agregar.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(filasDatos[1]));
            agregar.Parameters.AddWithValue("@Unidad_de_medida", filasDatos[2]);
            agregar.Parameters.AddWithValue("@No_de_identificacion", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Descripcion", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Precio_unitario", Convert.ToDecimal(filasDatos[5]));
            agregar.Parameters.AddWithValue("@Importe", Convert.ToDecimal(filasDatos[6]));
            agregar.Parameters.AddWithValue("@Numero_pedimento", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Fecha", filasDatos[8]);
            agregar.Parameters.AddWithValue("@Aduana", filasDatos[9]);
            agregar.Parameters.AddWithValue("@Codigo_de_producto_servicio_sat", filasDatos[10]);

            try
            {
                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente10(string[] filasDatos)
        {

            if (filasDatos[1] == "")
            {
                filasDatos[1] = " ";
            }


            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_10_Informacion_predial (Numero) VALUES (@Numero)", conexion);


            try
            {

                agregar.Parameters.AddWithValue("@Numero", filasDatos[1]);

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }

        }
        private void insertatabladatoscliente9(string[] filasDatos)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }




            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_09_Informacion_aduanera (Numero_de_pedimento,Fecha,Aduana) VALUES (@Numero_de_pedimento,@Fecha,@Aduana)", conexion);


            try
            {

                agregar.Parameters.AddWithValue("@Numero_de_pedimento", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Fecha", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Aduana", filasDatos[3]);

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente8(string[] filasDatos)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }




            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_08_Relacion_de_informacion_adicional_sobre_el_producto (Consecutivos,Descripcion_adicional,Observaciones,Montoadicional1,Montoadicional2,Montoadicional3,Montoadicional4,Montoadicional5) VALUES (@Consecutivos,@Descripcion_adicional,@Observaciones,@Montoadicional1,@Montoadicional2,@Montoadicional3,@Montoadicional4,@Montoadicional5)", conexion);


            try
            {

                agregar.Parameters.AddWithValue("@Consecutivos", filasDatos[1]);
                agregar.Parameters.AddWithValue("@Descripcion_adicional", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Observaciones", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Montoadicional1", filasDatos[4]);
                agregar.Parameters.AddWithValue("@Montoadicional2", filasDatos[5]);
                agregar.Parameters.AddWithValue("@Montoadicional3", filasDatos[6]);
                agregar.Parameters.AddWithValue("@Montoadicional14", filasDatos[7]);
                agregar.Parameters.AddWithValue("@Montoadicional15", filasDatos[8]);

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente7(string[] filasDatos)
        {

            if (filasDatos[4] == "")
            {
                filasDatos[4] = "0.00";
            }
            if (filasDatos[6] == "")
            {
                filasDatos[6] = "0.00";
            }
            if (filasDatos[8] == "")
            {
                filasDatos[8] = "0.00";
            }
            if (filasDatos[10] == "")
            {
                filasDatos[10] = "0.00";
            }
            for (int i = 0; i <= 10; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }




            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi (Codigo_producto_servicioSAt,ClaveUnidad_de_medidasat,Tipo_de_factor_iva_traslado,Base_iva_traslado,Tipo_de_factor_ieps_traslado,Base_de_ieps_traslado,Tipo_de_factor_iva_retenido,Base_de_iva_retenido,Tipo_de_factor_isr_retenido,Base_de_isr_retenido) VALUES (@Codigo_producto_servicioSAt,@ClaveUnidad_de_medidasat,@Tipo_de_factor_iva_traslado,@Base_iva_traslado,@Tipo_de_factor_ieps_traslado,@Base_de_ieps_traslado,@Tipo_de_factor_iva_retenido,@Base_de_iva_retenido,@Tipo_de_factor_isr_retenido,@Base_de_isr_retenido)", conexion);


            try
            {

                agregar.Parameters.AddWithValue("@Codigo_producto_servicioSAt", filasDatos[1]);
                agregar.Parameters.AddWithValue("@ClaveUnidad_de_medidasat", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Tipo_de_factor_iva_traslado", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Base_iva_traslado", Convert.ToDecimal(filasDatos[4]));
                agregar.Parameters.AddWithValue("@Tipo_de_factor_ieps_traslado", filasDatos[5]);
                agregar.Parameters.AddWithValue("@Base_de_ieps_traslado", Convert.ToDecimal(filasDatos[6]));
                agregar.Parameters.AddWithValue("@Tipo_de_factor_iva_retenido", filasDatos[7]);
                agregar.Parameters.AddWithValue("@Base_de_iva_retenido", Convert.ToDecimal(filasDatos[8]));
                agregar.Parameters.AddWithValue("@Tipo_de_factor_isr_retenido", filasDatos[9]);
                agregar.Parameters.AddWithValue("@Base_de_isr_retenido", Convert.ToDecimal(filasDatos[10]));

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }

        }
        private void insertatabladatoscliente6(string[] filasDatos)
        {

            //Esto permite validar si el campo esta vacio lo rellena con un espacio para que no marque error
            for (int i = 5; i <= 17; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = "0.00";
                }
            }
            for (int i = 0; i <= 4; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }




            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_06_Conceptos_que_integran_la_factura (Nombre,Codigo,Descripcion,Unidad_medida,Precio_unitario,Cantidad,Porcentaje_descuento,Monto_descuento,Importe,Porcentaje_iva,Monto_iva,Porcentaje_ieps,Monto_ieps,Porcentaje_iva_retenido,Monto_iva_retenido,Porcentaje_isr,Monto_isr) VALUES (@Nombre,@Codigo,@Descripcion,@Unidad_medida,@Precio_unitario,@Cantidad,@Porcentaje_descuento,@Monto_descuento,@Importe,@Porcentaje_iva,@Monto_iva,@Porcentaje_ieps,@Monto_ieps,@Porcentaje_iva_retenido,@Monto_iva_retenido,@Porcentaje_isr,@Monto_isr)", conexion);


            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en-US");


                agregar.Parameters.Add("@Nombre", SqlDbType.Char);
                agregar.Parameters["@Nombre"].Value = filasDatos[1];
                agregar.Parameters.Add("@Codigo", SqlDbType.Char);
                agregar.Parameters["@Codigo"].Value = filasDatos[2];

                agregar.Parameters.Add("@Descripcion", SqlDbType.Char);
                agregar.Parameters["@Descripcion"].Value = filasDatos[3];

                agregar.Parameters.Add("@Unidad_medida", SqlDbType.Char);
                agregar.Parameters["@Unidad_medida"].Value = filasDatos[4];

                agregar.Parameters.Add("@Precio_unitario", SqlDbType.Decimal);
                agregar.Parameters["@Precio_unitario"].Value = Math.Round(decimal.Parse(filasDatos[5], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Cantidad", SqlDbType.Decimal);
                agregar.Parameters["@Cantidad"].Value = Math.Round(decimal.Parse(filasDatos[6], CultureInfo.InvariantCulture), 2);


                agregar.Parameters.Add("@Porcentaje_descuento", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_descuento"].Value = Math.Round(decimal.Parse(filasDatos[7], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Monto_descuento", SqlDbType.Decimal);
                agregar.Parameters["@Monto_descuento"].Value = Math.Round(decimal.Parse(filasDatos[8], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Importe", SqlDbType.Decimal);
                agregar.Parameters["@Importe"].Value = Math.Round(decimal.Parse(filasDatos[9], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Porcentaje_iva", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_iva"].Value = Math.Round(decimal.Parse(filasDatos[10], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Monto_iva", SqlDbType.Decimal);
                agregar.Parameters["@Monto_iva"].Value = Math.Round(decimal.Parse(filasDatos[11], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Porcentaje_ieps", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_ieps"].Value = Math.Round(decimal.Parse(filasDatos[12], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Monto_ieps", SqlDbType.Decimal);
                agregar.Parameters["@Monto_ieps"].Value = Math.Round(decimal.Parse(filasDatos[13], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Porcentaje_iva_retenido", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_iva_retenido"].Value = Math.Round(decimal.Parse(filasDatos[14], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Monto_iva_retenido", SqlDbType.Decimal);
                agregar.Parameters["@Monto_iva_retenido"].Value = Math.Round(decimal.Parse(filasDatos[15], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Porcentaje_isr", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_isr"].Value = Math.Round(decimal.Parse(filasDatos[16], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Monto_isr", SqlDbType.Decimal);
                agregar.Parameters["@Monto_isr"].Value = Math.Round(decimal.Parse(filasDatos[17], CultureInfo.InvariantCulture), 2);

                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }

        }
        private void insertatabladatoscliente5(string[] filasDatos)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }
            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_05_Listado_de_cfdi_relacionados (UUID) VALUES (UUID)", conexion);
            try
            {
                agregar.Parameters.AddWithValue("@UUID", filasDatos[1]);


                conexion.Open();

                agregar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente4(string[] filasDatos)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }
            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_04_Informacion_general_sobre_cfdi (Tipo_de_relacion) VALUES (@Tipo_de_relacion)", conexion);
            try
            {
                agregar.Parameters.AddWithValue("@Tipo_de_relacion", filasDatos[1]);


                conexion.Open();

                agregar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void insertatabladatoscliente3(string[] filasDatos)
        {
            for (int i = 0; i <= 5; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }
            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_03_informacion_complementaria_para_cfdi3 (Uso_del_cfdi,CondicionesPago,Codigo_de_confirmacion,Registro_de_identidad_fiscal_del_receptor,Residencia_fiscal) VALUES (@Uso_del_cfdi,@CondicionesPago,@Codigo_de_confirmacion,@Registro_de_identidad_fiscal_del_receptor,@Residencia_fiscal)", conexion);
            try
            {
                
                agregar.Parameters.AddWithValue("@Uso_del_cfdi", filasDatos[1]);
                agregar.Parameters.AddWithValue("@CondicionesPago", filasDatos[2]);
                agregar.Parameters.AddWithValue("@Codigo_de_confirmacion", filasDatos[3]);
                agregar.Parameters.AddWithValue("@Registro_de_identidad_fiscal_del_receptor", filasDatos[4]);
                agregar.Parameters.AddWithValue("@Residencia_fiscal", filasDatos[5]);


                conexion.Open();

                agregar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void insertatabladatoscliente2(string[] filasDatos)
        {



            
           try
           {
                for (int i = 0; i <= 4; i++)
                {
                    if (filasDatos[i] == "" || filasDatos[i] == null)
                    {

                        filasDatos[i] = "0";


                    }
                    filasDatos[i] = String.Concat(filasDatos[i].Where(c => !Char.IsWhiteSpace(c)));

                }
                for (int i = 5; i <= 14; i++)
                {
                    if (filasDatos[i] == "" || filasDatos[i] == null)
                    {

                        filasDatos[i] = "N";
                    }
                    filasDatos[i] = String.Concat(filasDatos[i].Where(c => !Char.IsWhiteSpace(c)));

                }



                for (int i = 15; i <= 22; i++)
                {

                    if (filasDatos[i] == "" || filasDatos[i] == null)
                    {
                        filasDatos[i] = "0.0";

                    }
                    filasDatos[i] = String.Concat(filasDatos[i].Where(c => !Char.IsWhiteSpace(c)));
                    filasDatos[i] = String.Format("{0:0.00}", filasDatos[i]);
                }







                SqlCommand agregar = new SqlCommand("INSERT INTO TBL_02 (Subtotal,Descuento,Porcentaje_Descuento,Total,Forma_de_pago,Motivo_descuento,Asunto,Tipo_de_comprobante,Observaciones,Metodo_de_pago,Cuenta_de_pago,Tipo_de_impuesto,Lugar_de_expedicion,Moneda,Tipo_de_cambio,Monto_total_de_iva,Tasa_iva_grupal,Monto_ieps_total,Tasa_ieps_grupal,Monto_iva_retenido,Monto_isr) VALUES (@Subtotal,@Descuento,@Porcentaje_Descuento,@Total,@Forma_de_pago,@Motivo_descuento,@Asunto,@Tipo_de_comprobante,@Observaciones,@Metodo_de_pago,@Cuenta_de_pago,@Tipo_de_impuesto,@Lugar_de_expedicion,@Moneda,@Tipo_de_cambio,@Monto_total_de_iva,@Tasa_iva_grupal,@Monto_ieps_total,@Tasa_ieps_grupal,@Monto_iva_retenido,@Monto_isr)", conexion);
                CultureInfo.CurrentUICulture = new CultureInfo("en-US");




                agregar.Parameters.Add("@Subtotal", SqlDbType.Decimal);
                agregar.Parameters["@Subtotal"].Value = Math.Round(decimal.Parse(filasDatos[1], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Descuento", SqlDbType.Decimal);
                agregar.Parameters["@Descuento"].Value = Math.Round(decimal.Parse(filasDatos[2], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Porcentaje_Descuento", SqlDbType.Decimal);
                agregar.Parameters["@Porcentaje_Descuento"].Value = Math.Round(decimal.Parse(filasDatos[3], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Total", SqlDbType.Decimal);
                agregar.Parameters["@Total"].Value = Math.Round(decimal.Parse(filasDatos[4], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Forma_de_pago", SqlDbType.Char);
                agregar.Parameters["@Forma_de_pago"].Value = filasDatos[5];
                agregar.Parameters.Add("@Motivo_descuento", SqlDbType.Char);
                agregar.Parameters["@Motivo_descuento"].Value = filasDatos[6];
                agregar.Parameters.Add("@Asunto", SqlDbType.Char);
                agregar.Parameters["@Asunto"].Value = filasDatos[7];
                agregar.Parameters.Add("@Tipo_de_comprobante", SqlDbType.Char);
                agregar.Parameters["@Tipo_de_comprobante"].Value = filasDatos[8];
                agregar.Parameters.Add("@Observaciones", SqlDbType.Char);
                agregar.Parameters["@Observaciones"].Value = filasDatos[9];
                agregar.Parameters.Add("@Metodo_de_pago", SqlDbType.Char);
                agregar.Parameters["@Metodo_de_pago"].Value = filasDatos[10];
                agregar.Parameters.Add("@Cuenta_de_pago", SqlDbType.Char);
                agregar.Parameters["@Cuenta_de_pago"].Value = filasDatos[11];
                agregar.Parameters.Add("@Tipo_de_impuesto", SqlDbType.Char);
                agregar.Parameters["@Tipo_de_impuesto"].Value = filasDatos[12];
                agregar.Parameters.Add("@Lugar_de_expedicion", SqlDbType.Char);
                agregar.Parameters["@Lugar_de_expedicion"].Value = filasDatos[13];
                agregar.Parameters.Add("@Moneda", SqlDbType.Char);
                agregar.Parameters["@Moneda"].Value = filasDatos[14];
                agregar.Parameters.Add("@Tipo_de_cambio", SqlDbType.Decimal);
                agregar.Parameters["@Tipo_de_cambio"].Value = Math.Round(decimal.Parse(filasDatos[15], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Monto_total_de_iva", SqlDbType.Decimal);
                agregar.Parameters["@Monto_total_de_iva"].Value = Math.Round(decimal.Parse(filasDatos[16], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Tasa_iva_grupal", SqlDbType.Decimal);
                agregar.Parameters["@Tasa_iva_grupal"].Value = Math.Round(decimal.Parse(filasDatos[17], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Monto_ieps_total", SqlDbType.Decimal);
                agregar.Parameters["@Monto_ieps_total"].Value = Math.Round(decimal.Parse(filasDatos[18], CultureInfo.InvariantCulture), 2);

                agregar.Parameters.Add("@Tasa_ieps_grupal", SqlDbType.Decimal);
                agregar.Parameters["@Tasa_ieps_grupal"].Value = Math.Round(decimal.Parse(filasDatos[19], CultureInfo.InvariantCulture), 2);
                agregar.Parameters.Add("@Monto_iva_retenido", SqlDbType.Decimal);
                agregar.Parameters["@Monto_iva_retenido"].Value = Math.Round(decimal.Parse(filasDatos[20], CultureInfo.InvariantCulture), 2);


                agregar.Parameters.Add("@Monto_isr", SqlDbType.Decimal);
                agregar.Parameters["@Monto_isr"].Value = Math.Round(decimal.Parse(filasDatos[21], CultureInfo.InvariantCulture), 2);



                conexion.Open();

                agregar.ExecuteNonQuery();




            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            finally
            {
                conexion.Close();
            }
            }
        public void insertatabladatoscliente(string[] filasDatos)
        {


            //Esto permite validar si el campo esta vacio lo rellena con un espacio para que no marque error
            for (int i = 0; i <= 5; i++)
            {
                if (filasDatos[i] == "")
                {
                    filasDatos[i] = " ";
                }
            }



            SqlCommand agregar = new SqlCommand("INSERT INTO TBL_01 (Nombre,Tipo_Persona,RFC_Destinatario,Nombres_s,Apellidos,Email,Telefono,Calle,No_Interior,No_exterior,Ciudad,Colonia,Municipio,CP,Estado,Pais,Referencia,RFC_Emisor,Notificar,Referencia1,Referencia2,Referencia3) VALUES (@Nombre, @Tipo_Persona, @RFC_Destinatario, @Nombre_s, @Apellidos, @Email, @Telefono, @Calle, @No_Interior, @No_exterior, @Ciudad, @Colonia, @Municipio, @CP, @Estado, @Pais, @Referencia, @RFC_Emisor, @Notificar, @Referencia1, @Referencia2, @Referencia3)", conexion);




            agregar.Parameters.AddWithValue("@Nombre", filasDatos[1]);
            agregar.Parameters.AddWithValue("@Tipo_Persona", filasDatos[2]);
            agregar.Parameters.AddWithValue("@RFC_Destinatario", filasDatos[3]);
            agregar.Parameters.AddWithValue("@Nombre_s", filasDatos[4]);
            agregar.Parameters.AddWithValue("@Apellidos", filasDatos[5]);
            agregar.Parameters.AddWithValue("@Email", filasDatos[6]);
            agregar.Parameters.AddWithValue("@Telefono", filasDatos[7]);
            agregar.Parameters.AddWithValue("@Calle", filasDatos[8]);
            agregar.Parameters.AddWithValue("@No_Interior", filasDatos[9]);
            agregar.Parameters.AddWithValue("@No_exterior", filasDatos[10]);
            agregar.Parameters.AddWithValue("@Ciudad", filasDatos[11]);
            agregar.Parameters.AddWithValue("@Colonia", filasDatos[12]);
            agregar.Parameters.AddWithValue("@Municipio", filasDatos[13]);
            agregar.Parameters.AddWithValue("@CP", filasDatos[14]);
            agregar.Parameters.AddWithValue("@Estado", filasDatos[15]);
            agregar.Parameters.AddWithValue("@Pais", filasDatos[16]);
            agregar.Parameters.AddWithValue("@Referencia", filasDatos[17]);
            agregar.Parameters.AddWithValue("@RFC_Emisor", filasDatos[18]);
            agregar.Parameters.AddWithValue("@Notificar", filasDatos[19]);
            agregar.Parameters.AddWithValue("@Referencia1", filasDatos[20]);
            agregar.Parameters.AddWithValue("@Referencia2", filasDatos[21]);
            agregar.Parameters.AddWithValue("@Referencia3", filasDatos[22]);


            try
            {


                conexion.Open();

                agregar.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos" + ex);
            }
            finally
            {
                conexion.Close();
            }


        }
       

    }


}

