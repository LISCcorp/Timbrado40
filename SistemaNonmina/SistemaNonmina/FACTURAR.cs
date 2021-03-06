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
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;



namespace SistemaNonmina
{
    public partial class FACTURAR : Form
    {
        Menu pantalla;
        SqlConnection cn;
        public FACTURAR()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = "server=DESKTOP-2TMBJAF ; database= PERSONAS2 ; INTEGRATED SECURITY = TRUE";
                cn.Open();
                String cad = "SELECT TBL_01.id, TBL_01.Identificador, TBL_01.Nombre, TBL_01.Tipo_Persona, TBL_01.RFC_Destinatario, TBL_01.Nombres_s, TBL_01.Apellidos,TBL_01.Email, TBL_01.Telefono, TBL_01.Calle, TBL_01.No_Interior, TBL_01.No_exterior, TBL_01.Ciudad, TBL_01.Colonia, TBL_01.Municipio, TBL_01.CP, TBL_01.Estado, TBL_01.Pais,TBL_01.Referencia, TBL_01.RFC_Emisor, TBL_01.Notificar, TBL_01.Referencia1,TBL_01.Referencia2,TBL_01.Referencia3, TBL_02.Identificador, TBL_02.Subtotal, TBL_02.Descuento, TBL_02.Porcentaje_Descuento,TBL_02.Total, TBL_02.Forma_de_pago,TBL_02.Motivo_descuento,TBL_02.Asunto, TBL_02.Tipo_de_comprobante, TBL_02.Observaciones,TBL_02.Metodo_de_pago, TBL_02.Cuenta_de_pago,TBL_02.Tipo_de_impuesto,TBL_02.Lugar_de_expedicion, TBL_02.Moneda, TBL_02.Tipo_de_cambio, TBL_02.Monto_total_de_iva, TBL_02.Tasa_iva_grupal,TBL_02.Monto_ieps_total,TBL_02.Tasa_ieps_grupal,TBL_02.Monto_iva_retenido, TBL_02.Monto_isr, TBL_03_informacion_complementaria_para_cfdi3.Identificador,TBL_03_informacion_complementaria_para_cfdi3.Uso_del_cfdi,TBL_03_informacion_complementaria_para_cfdi3.CondicionesPago,TBL_03_informacion_complementaria_para_cfdi3.Codigo_de_confirmacion,TBL_03_informacion_complementaria_para_cfdi3.Registro_de_identidad_fiscal_del_receptor, TBL_03_informacion_complementaria_para_cfdi3.Residencia_fiscal,TBL_04_Informacion_general_sobre_cfdi.Identificador,TBL_04_Informacion_general_sobre_cfdi.Tipo_de_relacion, TBL_05_Listado_de_cfdi_relacionados.Identificador,TBL_05_Listado_de_cfdi_relacionados.UUID, TBL_06_Conceptos_que_integran_la_factura.Identificador, TBL_06_Conceptos_que_integran_la_factura.Nombre,TBL_06_Conceptos_que_integran_la_factura.Codigo,TBL_06_Conceptos_que_integran_la_factura.Descripcion,TBL_06_Conceptos_que_integran_la_factura.Unidad_medida,TBL_06_Conceptos_que_integran_la_factura.Precio_unitario,TBL_06_Conceptos_que_integran_la_factura.Cantidad,TBL_06_Conceptos_que_integran_la_factura.Porcentaje_descuento,TBL_06_Conceptos_que_integran_la_factura.Monto_descuento,TBL_06_Conceptos_que_integran_la_factura.Importe,TBL_06_Conceptos_que_integran_la_factura.Porcentaje_iva,TBL_06_Conceptos_que_integran_la_factura.Monto_iva,TBL_06_Conceptos_que_integran_la_factura.Porcentaje_ieps,TBL_06_Conceptos_que_integran_la_factura.Monto_ieps,TBL_06_Conceptos_que_integran_la_factura.Porcentaje_iva_retenido,TBL_06_Conceptos_que_integran_la_factura.Monto_iva_retenido,TBL_06_Conceptos_que_integran_la_factura.Porcentaje_isr,TBL_06_Conceptos_que_integran_la_factura.Monto_isr,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Identificador,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Codigo_producto_servicioSAt,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.ClaveUnidad_de_medidasat,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Tipo_de_factor_iva_traslado,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Base_iva_traslado,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Tipo_de_factor_ieps_traslado,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Base_de_ieps_traslado,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Tipo_de_factor_iva_retenido,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Base_de_iva_retenido,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Tipo_de_factor_isr_retenido,TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.Base_de_isr_retenido,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Identificador,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Consecutivos,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Descripcion_adicional,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Observaciones,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Montoadicional1,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Montoadicional2,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Montoadicional3,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Montoadicional4,TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.Montoadicional5,TBL_09_Informacion_aduanera.Identificador,TBL_09_Informacion_aduanera.Numero_de_pedimento,TBL_09_Informacion_aduanera.Fecha,TBL_09_Informacion_aduanera.Aduana,TBL_10_Informacion_predial.Identificador,TBL_10_Informacion_predial.Numero,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Identificador,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Cantidad,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Unidad_de_medida,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.No_de_identificacion,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Descripcion,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Precio_unitario,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Importe,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Numero_pedimento,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Fecha,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Aduana,TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.Codigo_de_producto_servicio_sat,TBL_12_Informacion_adicional_del_producto.Identificador,TBL_12_Informacion_adicional_del_producto.Costo,TBL_12_Informacion_adicional_del_producto.Codigo1,TBL_12_Informacion_adicional_del_producto.Codigo2,TBL_12_Informacion_adicional_del_producto.Codigo3,TBL_12_Informacion_adicional_del_producto.Codigo4,TBL_12_Informacion_adicional_del_producto.Codigo5,TBL_12_Informacion_adicional_del_producto.Impuesto1,TBL_12_Informacion_adicional_del_producto.Montoimpuesto1,TBL_12_Informacion_adicional_del_producto.Porcentajeimpuesto1,TBL_12_Informacion_adicional_del_producto.Impuesto2,TBL_12_Informacion_adicional_del_producto.Montoimpuesto2,TBL_12_Informacion_adicional_del_producto.Porcentajeimpuesto2,TBL_12_Informacion_adicional_del_producto.Impuesto3,TBL_12_Informacion_adicional_del_producto.Montoimpuesto3,TBL_12_Informacion_adicional_del_producto.Porcentajeimpuesto3,TBL_12_Informacion_adicional_del_producto.Impuesto4,TBL_12_Informacion_adicional_del_producto.Montoimpuesto4,TBL_12_Informacion_adicional_del_producto.Porcentajeimpuesto4,TBL_12_Informacion_adicional_del_producto.Impuesto5,TBL_12_Informacion_adicional_del_producto.Montoimpuesto5,TBL_12_Informacion_adicional_del_producto.Porcentajeimpuesto5,TBL_12_Informacion_adicional_del_producto.Peso,TBL_12_Informacion_adicional_del_producto.Volumen,TBL_12_Informacion_adicional_del_producto.Cajas,TBL_12_Informacion_adicional_del_producto.Paisorigen,TBL_12_Informacion_adicional_del_producto.Ordencompra,TBL_12_Informacion_adicional_del_producto.Adicional1,TBL_12_Informacion_adicional_del_producto.Adicional2,TBL_12_Informacion_adicional_del_producto.Adicional3,TBL_12_Informacion_adicional_del_producto.Adicional4,TBL_12_Informacion_adicional_del_producto.Adicional5,TBL_12_Informacion_adicional_del_producto.Montoadicional1,TBL_12_Informacion_adicional_del_producto.Montoadicional2,TBL_12_Informacion_adicional_del_producto.Montoadicional3,TBL_12_Informacion_adicional_del_producto.Montoadicional4,TBL_12_Informacion_adicional_del_producto.Montoadicional5,TBL_12_Informacion_adicional_del_producto.Montoadicional6,TBL_12_Informacion_adicional_del_producto.Montoadicional7,TBL_12_Informacion_adicional_del_producto.Montoadicional8,TBL_12_Informacion_adicional_del_producto.Montoadicional9,TBL_12_Informacion_adicional_del_producto.Montoadicional10,TBL_13_Informacion_de_comercio_exterior.Identificador,TBL_13_Informacion_de_comercio_exterior.Motivo_de_traslado,TBL_13_Informacion_de_comercio_exterior.TipoOperecion,TBL_13_Informacion_de_comercio_exterior.Clave_de_pedimento,TBL_13_Informacion_de_comercio_exterior.Certificado_origen,TBL_13_Informacion_de_comercio_exterior.Numero_de_certificado_de_origen,TBL_13_Informacion_de_comercio_exterior.Numero_de_exportador_confiable,TBL_13_Informacion_de_comercio_exterior.No_incoterm,TBL_13_Informacion_de_comercio_exterior.Subdivision,TBL_13_Informacion_de_comercio_exterior.Observacion,TBL_13_Informacion_de_comercio_exterior.Tipo_de_cambio_usd,TBL_13_Informacion_de_comercio_exterior.Monto_en_dolares,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Identificador,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Curp,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Calle,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.No_exterior,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.No_interior,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Colonia,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Localidad,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Referencia,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Municipio,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Estado,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Pais,TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.Codigo_postal,TBL_15_Datos_complementarios_del_propietario_de_las_mercancias_en_el_caso_de_cfdi_con_complementos_de_comercio_exterior.Identificador,TBL_15_Datos_complementarios_del_propietario_de_las_mercancias_en_el_caso_de_cfdi_con_complementos_de_comercio_exterior.No_registro_fiscal,TBL_15_Datos_complementarios_del_propietario_de_las_mercancias_en_el_caso_de_cfdi_con_complementos_de_comercio_exterior.Residencia_fiscal,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Identificador,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.No_registro_fiscal,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Calle,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.No_exterior,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.No_interior,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Colonia,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Localidad,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Referencia,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Municipio,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Estado,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Pais,TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.Codigo_postal,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Identificador,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.No_registro_fiscal,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Nombre,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Calle,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.No_Exterior,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.No_interior,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Colonia,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Localidad,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Referencia,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Municipio,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Estado,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Pais,TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.Codigo_postal,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Identificador,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.No_identificacion,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Fraccion_arancelaria,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Cantidad_en_aduana,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Unidad_de_Medida_aduana,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Valor_unitario,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Valor_en_dolares,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Marca,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.Modelo,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.SubModelo,TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.No_serie,TBL_19_Complementos_de_pago.Identificador,TBL_19_Complementos_de_pago.Fecha_de_pago,TBL_19_Complementos_de_pago.Forma_de_pago,TBL_19_Complementos_de_pago.Moneda,TBL_19_Complementos_de_pago.Tipo_de_cambio,TBL_19_Complementos_de_pago.Monto_del_pago,TBL_19_Complementos_de_pago.No_de_operacion,TBL_19_Complementos_de_pago.Rfc_emisor_cuenta_ordenante,TBL_19_Complementos_de_pago.Nombre_banco_ordenante_extranjero,TBL_19_Complementos_de_pago.Cuenta_ordenante,TBL_19_Complementos_de_pago.Rfc_emisor_cuenta_beneficiario,TBL_19_Complementos_de_pago.Cuenta_beneficiario,TBL_19_Complementos_de_pago.Tipo_de_cadena_de_pago,TBL_19_Complementos_de_pago.Certificado_del_pago,TBL_19_Complementos_de_pago.Cadena_original_de_pago,TBL_19_Complementos_de_pago.Sello_digital_del_pago,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Identificador,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Id_documento_relacionado,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Serie,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Folio,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Moneda,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Tipo_de_cambio,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Metodo_de_pago,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Numero_de_parcialidad,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Importe_saldo_anterior,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Importe_pagado,TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.Importe_saldo_insoluto,TBL_21_Informacion_para_emision_de_cfdi_nomina.Identificador,TBL_21_Informacion_para_emision_de_cfdi_nomina.Registro_patronal,TBL_21_Informacion_para_emision_de_cfdi_nomina.Numero_de_empleado,TBL_21_Informacion_para_emision_de_cfdi_nomina.Clave_curp,TBL_21_Informacion_para_emision_de_cfdi_nomina.Tipo_de_regimen,TBL_21_Informacion_para_emision_de_cfdi_nomina.Numero_de_seguridad_social,TBL_21_Informacion_para_emision_de_cfdi_nomina.Fecha_de_pago,TBL_21_Informacion_para_emision_de_cfdi_nomina.Fecha_inicial_de_pago,TBL_21_Informacion_para_emision_de_cfdi_nomina.Fecha_final_de_pago,TBL_21_Informacion_para_emision_de_cfdi_nomina.Dias_pagados,TBL_21_Informacion_para_emision_de_cfdi_nomina.Nobre_departamento,TBL_21_Informacion_para_emision_de_cfdi_nomina.Cuenta_bancaria,TBL_21_Informacion_para_emision_de_cfdi_nomina.Clave_banco,TBL_21_Informacion_para_emision_de_cfdi_nomina.Fecha_laboral_de_inicio,TBL_21_Informacion_para_emision_de_cfdi_nomina.Antiguedad,TBL_21_Informacion_para_emision_de_cfdi_nomina.Puesto,TBL_21_Informacion_para_emision_de_cfdi_nomina.Tipo_de_contrato,TBL_21_Informacion_para_emision_de_cfdi_nomina.Tipo_de_jornada,TBL_21_Informacion_para_emision_de_cfdi_nomina.Periodicidad_del_pago,TBL_21_Informacion_para_emision_de_cfdi_nomina.Salario_base_cotizacion_por_aportaciones,TBL_21_Informacion_para_emision_de_cfdi_nomina.Riesgo_del_puesto,TBL_21_Informacion_para_emision_de_cfdi_nomina.Salario_diario_integrado,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_percepciones_gravadas,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_percepciones_excentas,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_otras_deducciones,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_impuestos_retenidos,TBL_21_Informacion_para_emision_de_cfdi_nomina.Tipo_de_nomina,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_percepciones,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_sueldos,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_conceptos_por_separacion_e_indemnizacion,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_conceptos_por_jubilacion_pension_retiro,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_de_deducciones,TBL_21_Informacion_para_emision_de_cfdi_nomina.Total_otros_pagos,TBL_21_Informacion_para_emision_de_cfdi_nomina.Curp_del_emisor,TBL_21_Informacion_para_emision_de_cfdi_nomina.Rfc_patron_origen,TBL_21_Informacion_para_emision_de_cfdi_nomina.Trabajados_sindicalizado,TBL_21_Informacion_para_emision_de_cfdi_nomina.Clave_de_entidad_federativa,TBL_22_Informacion_para_emision_de_cfdi_nomina_para_entidades_adheridas_al_sistema_nacional_de_coordinacion_fiscal.Identificador,TBL_22_Informacion_para_emision_de_cfdi_nomina_para_entidades_adheridas_al_sistema_nacional_de_coordinacion_fiscal.Origen_del_recurso,TBL_23_Informacion_de_datos_de_subcontratacion_del_empleo.Identificador,TBL_23_Informacion_de_datos_de_subcontratacion_del_empleo.Rfc_subcontratador,TBL_23_Informacion_de_datos_de_subcontratacion_del_empleo.Porcentaje_de_tiempo,TBL_24_Conceptos_de_percepciones_por_nomina.Identificador,TBL_24_Conceptos_de_percepciones_por_nomina.Tipo_de_percepcion,TBL_24_Conceptos_de_percepciones_por_nomina.Clave_de_percepcion,TBL_24_Conceptos_de_percepciones_por_nomina.Descripcion,TBL_24_Conceptos_de_percepciones_por_nomina.Importe_gravado,TBL_24_Conceptos_de_percepciones_por_nomina.Importe_exento,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Identificador,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Tipo_de_otro_pago,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Clave_del_patron,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Concepto_de_otro_pago,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Importe_otro_pago,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Subsidio_al_empleo_causado,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Saldo_a_favor,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Año_saldo_a_favor,TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.Remanente_saldo_a_favor,TBL_26_Informacion_de_separacion_por_indemnizacion.Identificador,TBL_26_Informacion_de_separacion_por_indemnizacion.Total_pagado,TBL_26_Informacion_de_separacion_por_indemnizacion.Numero_de_años_de_servicios,TBL_26_Informacion_de_separacion_por_indemnizacion.Ultimo_sueldo_mensual_ordinario,TBL_26_Informacion_de_separacion_por_indemnizacion.Ingreso_acumulable,TBL_26_Informacion_de_separacion_por_indemnizacion.Ingreso_no_acumulable,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Identificador,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Total_una_exhibicion,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Total_parcialidad,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Monto_diario,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Ingreso_acumulable,TBL_27_Informacion_de_jubilacion_pension_y_retiro.Ingresi_no_acumulable,TBL_28_Informacion_de_percepciones_por_acciones_o_titulos.Identificador,TBL_28_Informacion_de_percepciones_por_acciones_o_titulos.Valor_del_mercado,TBL_28_Informacion_de_percepciones_por_acciones_o_titulos.Precio_al_otorgarse,TBL_29_Conceptos_de_duducciones_por_nomina.Identificador,TBL_29_Conceptos_de_duducciones_por_nomina.Tipo_de_deduccion,TBL_29_Conceptos_de_duducciones_por_nomina.Codigo_de_deduccion,TBL_29_Conceptos_de_duducciones_por_nomina.Descripcion,TBL_29_Conceptos_de_duducciones_por_nomina.Importe,TBL_29_Conceptos_de_duducciones_por_nomina.Vacio,TBL_30_Informacion_para_incapacidades_del_trabajador.Identificador,TBL_30_Informacion_para_incapacidades_del_trabajador.Dias_de_incapacidad,TBL_30_Informacion_para_incapacidades_del_trabajador.Tipo_de_incapacidad,TBL_30_Informacion_para_incapacidades_del_trabajador.Importe_Monetario_del_descuento,TBL_31_Informacion_para_horas_extras_laboradas.Identificador,TBL_31_Informacion_para_horas_extras_laboradas.Dias_de_trabajo,TBL_31_Informacion_para_horas_extras_laboradas.Tipo_de_horas,TBL_31_Informacion_para_horas_extras_laboradas.Horas,TBL_31_Informacion_para_horas_extras_laboradas.Importe,TBL_32_Informacion_para_impuestos_locales_retenidos.Identificador,TBL_32_Informacion_para_impuestos_locales_retenidos.Descripcion_del_impuesto,TBL_32_Informacion_para_impuestos_locales_retenidos.Tasa,TBL_32_Informacion_para_impuestos_locales_retenidos.Importe,TBL_33_Informacion_para_impuestos_locales_traslados.Identificador,TBL_33_Informacion_para_impuestos_locales_traslados.Descripcion_del_impuesto,TBL_33_Informacion_para_impuestos_locales_traslados.Tasa,TBL_33_Informacion_para_impuestos_locales_traslados.Importe,TBL_34_Informacion_de_recibos_referenciados_por_emision_de_nota_de_credito.Identificador,TBL_34_Informacion_de_recibos_referenciados_por_emision_de_nota_de_credito.Numero_de_recibo,TBL_35_Datos_del_domicilio_de_emision.Identificador,TBL_35_Datos_del_domicilio_de_emision.Calle,TBL_35_Datos_del_domicilio_de_emision.No_exterior,TBL_35_Datos_del_domicilio_de_emision.No_Interior,TBL_35_Datos_del_domicilio_de_emision.Colonia,TBL_35_Datos_del_domicilio_de_emision.Localidad,TBL_35_Datos_del_domicilio_de_emision.Municipio,TBL_35_Datos_del_domicilio_de_emision.CP,TBL_35_Datos_del_domicilio_de_emision.Estado,TBL_35_Datos_del_domicilio_de_emision.Pais,TBL_35_Datos_del_domicilio_de_emision.Referencia,TBL_36_Datos_adicionales_a_la_factura.Identificador,TBL_36_Datos_adicionales_a_la_factura.Campo01,TBL_36_Datos_adicionales_a_la_factura.Campo02,TBL_36_Datos_adicionales_a_la_factura.Campo03,TBL_36_Datos_adicionales_a_la_factura.Campo04,TBL_36_Datos_adicionales_a_la_factura.Campo05,TBL_36_Datos_adicionales_a_la_factura.Campo06,TBL_36_Datos_adicionales_a_la_factura.Campo07,TBL_36_Datos_adicionales_a_la_factura.Campo08,TBL_36_Datos_adicionales_a_la_factura.Campo09,TBL_36_Datos_adicionales_a_la_factura.Campo10,TBL_36_Datos_adicionales_a_la_factura.Campo11,TBL_36_Datos_adicionales_a_la_factura.Campo12,TBL_36_Datos_adicionales_a_la_factura.Campo13,TBL_36_Datos_adicionales_a_la_factura.Campo14,TBL_36_Datos_adicionales_a_la_factura.Campo15,TBL_36_Datos_adicionales_a_la_factura.Campo16,TBL_36_Datos_adicionales_a_la_factura.Campo18,TBL_36_Datos_adicionales_a_la_factura.Campo19,TBL_36_Datos_adicionales_a_la_factura.Campo20,TBL_36_Datos_adicionales_a_la_factura.Campo21,TBL_36_Datos_adicionales_a_la_factura.Campo22,TBL_36_Datos_adicionales_a_la_factura.Campo23,TBL_36_Datos_adicionales_a_la_factura.Campo24,TBL_36_Datos_adicionales_a_la_factura.Campo25,TBL_36_Datos_adicionales_a_la_factura.Campo26,TBL_36_Datos_adicionales_a_la_factura.Campo27,TBL_36_Datos_adicionales_a_la_factura.Campo28,TBL_36_Datos_adicionales_a_la_factura.Campo29,TBL_36_Datos_adicionales_a_la_factura.Campo30 FROM TBL_01 LEFT JOIN TBL_02 ON TBL_01.id = TBL_02.Id LEFT JOIN TBL_03_informacion_complementaria_para_cfdi3 ON TBL_01.id = TBL_03_informacion_complementaria_para_cfdi3.Id LEFT JOIN TBL_04_Informacion_general_sobre_cfdi ON TBL_01.id = TBL_04_Informacion_general_sobre_cfdi.id LEFT JOIN TBL_05_Listado_de_cfdi_relacionados ON TBL_01.id = TBL_05_Listado_de_cfdi_relacionados.id LEFT JOIN TBL_06_Conceptos_que_integran_la_factura ON TBL_01.id = TBL_06_Conceptos_que_integran_la_factura.id LEFT JOIN TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi ON TBL_01.id = TBL_07_Informacion_adicional_sobre_datos_del_producto_para_emision_de_cfdi.id LEFT JOIN TBL_08_Relacion_de_informacion_adicional_sobre_el_producto ON TBL_01.id = TBL_08_Relacion_de_informacion_adicional_sobre_el_producto.id LEFT JOIN TBL_09_Informacion_aduanera ON TBL_01.id = TBL_09_Informacion_aduanera.id LEFT JOIN TBL_10_Informacion_predial ON TBL_01.id = TBL_10_Informacion_predial.id LEFT JOIN TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera ON TBL_01.id = TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.id LEFT JOIN TBL_12_Informacion_adicional_del_producto ON TBL_01.id = TBL_12_Informacion_adicional_del_producto.id LEFT JOIN TBL_13_Informacion_de_comercio_exterior ON TBL_01.id = TBL_13_Informacion_de_comercio_exterior.id LEFT JOIN TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1 ON TBL_01.id = TBL_14_Datos_complementarios_del_emisor_con_complemento_de_comercio_exterior1_1.id LEFT JOIN TBL_15_Datos_complementarios_del_propietario_de_las_mercancias_en_el_caso_de_cfdi_con_complementos_de_comercio_exterior ON TBL_01.id = TBL_11_Informacion_de_partes_para_los_conceptos_einformacion_aduanera.id LEFT JOIN TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1 ON TBL_01.id = TBL_16_Datos_complementarios_del_receptor_con_complemento_de_comercio_exterior1_1.id LEFT JOIN TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1 ON TBL_01.id = TBL_17_Datos_complementarios_del_destinatario_con_complemento_de_comercio_exterior1_1.id LEFT JOIN TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1 ON TBL_01.id = TBL_18_Relacion_de_mercancias_del_complemento_de_comercio_exterior1_1.id LEFT JOIN TBL_19_Complementos_de_pago ON TBL_01.id = TBL_19_Complementos_de_pago.id LEFT JOIN TBL_20_Documentos_relacionados_para_el_complemento_de_pagos ON TBL_01.id = TBL_20_Documentos_relacionados_para_el_complemento_de_pagos.id LEFT JOIN TBL_21_Informacion_para_emision_de_cfdi_nomina ON TBL_01.id = TBL_21_Informacion_para_emision_de_cfdi_nomina.id LEFT JOIN TBL_22_Informacion_para_emision_de_cfdi_nomina_para_entidades_adheridas_al_sistema_nacional_de_coordinacion_fiscal ON TBL_01.id = TBL_22_Informacion_para_emision_de_cfdi_nomina_para_entidades_adheridas_al_sistema_nacional_de_coordinacion_fiscal.id LEFT JOIN TBL_23_Informacion_de_datos_de_subcontratacion_del_empleo ON TBL_01.id = TBL_23_Informacion_de_datos_de_subcontratacion_del_empleo.id LEFT JOIN TBL_24_Conceptos_de_percepciones_por_nomina ON TBL_01.id = TBL_24_Conceptos_de_percepciones_por_nomina.id LEFT JOIN TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales ON TBL_01.id = TBL_25_Informacion_para_informacion_de_otros_pagos_de_nomina_diferentes_ala_percepciones_normales.id LEFT JOIN TBL_26_Informacion_de_separacion_por_indemnizacion ON TBL_01.id = TBL_26_Informacion_de_separacion_por_indemnizacion.id LEFT JOIN TBL_27_Informacion_de_jubilacion_pension_y_retiro ON TBL_01.id = TBL_27_Informacion_de_jubilacion_pension_y_retiro.id LEFT JOIN TBL_28_Informacion_de_percepciones_por_acciones_o_titulos ON TBL_01.id = TBL_28_Informacion_de_percepciones_por_acciones_o_titulos.id LEFT JOIN TBL_29_Conceptos_de_duducciones_por_nomina ON TBL_01.id = TBL_29_Conceptos_de_duducciones_por_nomina.id LEFT JOIN TBL_30_Informacion_para_incapacidades_del_trabajador ON TBL_01.id = TBL_30_Informacion_para_incapacidades_del_trabajador.id LEFT JOIN TBL_31_Informacion_para_horas_extras_laboradas ON TBL_01.id = TBL_31_Informacion_para_horas_extras_laboradas.id LEFT JOIN TBL_32_Informacion_para_impuestos_locales_retenidos ON TBL_01.id = TBL_32_Informacion_para_impuestos_locales_retenidos.id LEFT JOIN TBL_33_Informacion_para_impuestos_locales_traslados ON TBL_01.id = TBL_33_Informacion_para_impuestos_locales_traslados.id LEFT JOIN TBL_34_Informacion_de_recibos_referenciados_por_emision_de_nota_de_credito ON TBL_01.id = TBL_34_Informacion_de_recibos_referenciados_por_emision_de_nota_de_credito.id LEFT JOIN TBL_35_Datos_del_domicilio_de_emision ON TBL_01.id = TBL_35_Datos_del_domicilio_de_emision.id LEFT JOIN TBL_36_Datos_adicionales_a_la_factura ON TBL_01.id = TBL_36_Datos_adicionales_a_la_factura.id";
                SqlDataAdapter da = new SqlDataAdapter(cad, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pantalla = new Menu();
            pantalla.Show();
            this.Hide();
        }


        static private string path = Directory.GetCurrentDirectory();
        static private string pathXML = @"C:\Users\abadm\source\repos\SistemaNonmina\xml\miprimerxml.xml";

        private void btnTimbrar_Click(object sender, EventArgs e)
        {

           //obtener numero de certificado

            string phatcer = path + @"cacx7605101p8.cer";
            string phatkey = path + @"Claveprivada_FIEL_CACX7605101P8_20190528_152826.key";
            string claveprivada = "12345678a";



            //obtiene el numero de certificado
            string numeroCertificado, aa, b, c;
            XSDToXML.Utils.SelloDigital.leerCER(phatcer, out aa, out b, out c, out numeroCertificado);

            //Llenamos la clase COMPROBANTE--------------------------------------------------------

            string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");


            Comprobante oComprobante = new Comprobante();
            oComprobante.Version = "4.0";
            oComprobante.Serie = "20211800";
            oComprobante.Folio = "4899900-000000623706";
            oComprobante.Fecha = fecha;

            oComprobante.FormaPago = Comprobante.c_FormaPago.Item99;

            oComprobante.NoCertificado = numeroCertificado;
            oComprobante.SubTotal = Convert.ToDecimal(11309.50);
            oComprobante.Descuento = Convert.ToDecimal(2749.69);
            oComprobante.Moneda = Comprobante.c_Moneda.MXN;
            oComprobante.Total = Convert.ToDecimal(8589.81);
            oComprobante.TipoDeComprobante = Comprobante.c_TipoDeComprobante.N;
            oComprobante.MetodoPago = Comprobante.c_MetodoPago.PUE;
            oComprobante.LugarExpedicion = "01070";


            ComprobanteEmisor oComprobanteEmisor = new ComprobanteEmisor();
            oComprobanteEmisor.Nombre = "SECRETARIA DE CULTURA";
            oComprobanteEmisor.RegimenFiscal = c_RegimenFiscal.Item603;
            oComprobanteEmisor.Rfc = "CNC881207TN3";

            ComprobanteReceptor oComprobanteReceptor = new ComprobanteReceptor();
            oComprobanteReceptor.Nombre = "FRANCISCO JAVIER AZPILCUETA CASTANEDA";
            oComprobanteReceptor.Rfc = "AICF701125AZ0";
            oComprobanteReceptor.UsoCFDI = c_UsoCFDI.P01;


            Conceptos oConceptos = new Conceptos();
            oConceptos.Descuento = Convert.ToDecimal("8786.00");
            oConceptos.importe = Convert.ToDecimal("85386532.00");
            oConceptos.ValorUnitario = Convert.ToDecimal("11271.00");
            oConceptos.Descripcion = "PAGO DE NOMINA";
            oConceptos.ClaveUnidad = "ACT";
            oConceptos.ClaveProServ = "84111505";

            Complemento oComplemento = new Complemento();
            oComplemento.Version = "4.0";

            oComplemento.NoCertificadoSat = numeroCertificado;

            oComplemento.RFCProCertif = "GRE100910KEA";
            oComplemento.FechaTimbrado = fecha;
            oComplemento.UUID = "86F9C0BD-7163-4156-8303-E0D7F17D4FA9";






            Nomina oNomina = new Nomina();
            oNomina.Version = "4.0";
            oNomina.TotalOtrosPagos = 0;
            oNomina.TotalDeducciones = 4730;
            oNomina.TotalPercepciones = 9302;
            oNomina.NumDiasPagados = 15;
            oNomina.FechaFinalPago = fecha;
            oNomina.FechaInicialPago = fecha;
            oNomina.FechaPago = fecha;
            oNomina.TipoNomina = c_TipoNomina.O;

            NominaEmisor oEmisor = new NominaEmisor();
            oEmisor.RfcPatronOrigen = "CNC881207TN3";
            oEmisor.RegistroPatronal = "48-99900";

            NominaReceptor oReceptor = new NominaReceptor();
            oReceptor.ClaveEntFed = c_Estado.DIF;
            oReceptor.SalarioDiarioIntegrado = 575;
            oReceptor.PeriodicidadPago = c_PeriodicidadPago.Item04;
            oReceptor.RiesgoPuesto = c_RiesgoPuesto.Item1;
            oReceptor.Puesto = "CF33E92";
            oReceptor.Departamento = "09ACR0005I";
            oReceptor.NumEmpleado = "AICC810120U64";
            oReceptor.TipoRegimen = c_TipoRegimen.Item02;
            oReceptor.TipoJornada = c_TipoJornada.Item01;
            oReceptor.TipoContrato = c_TipoContrato.Item03;
            oReceptor.Antigüedad = "P360W";
            oReceptor.FechaInicioRelLaboral = fecha;
            oReceptor.NumSeguridadSocial = "80158118937";
            oReceptor.Curp = "AICC810120HDFRRS00";



            NominaPercepciones oPercepciones = new NominaPercepciones();
            oPercepciones.TotalExento = Convert.ToDecimal("1884.97");
            oPercepciones.TotalGravado = Convert.ToDecimal("7417.93");
            oPercepciones.TotalSueldos = Convert.ToDecimal("9302.90");

            NominaPercepcionesPercepcion oPercepciones1 = new NominaPercepcionesPercepcion();
            oPercepciones1.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones1.ImporteGravado = Convert.ToDecimal("4049.03");
            oPercepciones1.Concepto = "SUELDO BASE";
            oPercepciones1.Clave = "007";
            oPercepciones1.TipoPercepcion = c_TipoPercepcion.Item001;

            NominaPercepcionesPercepcion oPercepciones2 = new NominaPercepcionesPercepcion();
            oPercepciones2.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones2.ImporteGravado = Convert.ToDecimal("920.73");
            oPercepciones2.Concepto = "COMPENSACION GARANTIZDA";
            oPercepciones2.Clave = "006";
            oPercepciones2.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaPercepcionesPercepcion oPercepciones3 = new NominaPercepcionesPercepcion();
            oPercepciones3.ImporteExento = Convert.ToDecimal("1214.71");
            oPercepciones3.ImporteGravado = Convert.ToDecimal("1214.71");
            oPercepciones3.Concepto = "HORAS EXTRAS";
            oPercepciones3.Clave = "019";
            oPercepciones3.TipoPercepcion = c_TipoPercepcion.Item019;

            NominaPercepcionesPercepcionHorasExtra oHorasExtra = new NominaPercepcionesPercepcionHorasExtra();
            oHorasExtra.ImportePagado = Convert.ToDecimal("2429.42");
            oHorasExtra.HorasExtra = 1;
            oHorasExtra.TipoHoras = c_TipoHoras.Item02;
            oHorasExtra.Dias = 1;

            NominaPercepcionesPercepcion oPercepciones4 = new NominaPercepcionesPercepcion();
            oPercepciones4.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones4.ImporteGravado = Convert.ToDecimal("76.15");
            oPercepciones4.Concepto = "AYUDA DE DESPENSA";
            oPercepciones4.Clave = "038";
            oPercepciones4.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaPercepcionesPercepcion oPercepciones5 = new NominaPercepcionesPercepcion();
            oPercepciones5.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones5.ImporteGravado = Convert.ToDecimal("93.45");
            oPercepciones5.Concepto = "PREVENSION SOCIAL MILTIPLE";
            oPercepciones5.Clave = "044";
            oPercepciones5.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaPercepcionesPercepcion oPercepciones6 = new NominaPercepcionesPercepcion();
            oPercepciones6.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones6.ImporteGravado = Convert.ToDecimal("56.48");
            oPercepciones6.Concepto = "AYUDA POR SERVICIOS";
            oPercepciones6.Clave = "046";
            oPercepciones6.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaPercepcionesPercepcion oPercepciones7 = new NominaPercepcionesPercepcion();
            oPercepciones7.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones7.ImporteGravado = Convert.ToDecimal("461.10");
            oPercepciones7.Concepto = "ASIGNACION DE APOYO A LA CULTURA";
            oPercepciones7.Clave = "079";
            oPercepciones7.TipoPercepcion = c_TipoPercepcion.Item038;


            NominaPercepcionesPercepcion oPercepciones8 = new NominaPercepcionesPercepcion();
            oPercepciones8.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones8.ImporteGravado = Convert.ToDecimal("431.45");
            oPercepciones8.Concepto = "COMPENSACION TEMPORAL COMPACTABLE";
            oPercepciones8.Clave = "0CC";
            oPercepciones8.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaPercepcionesPercepcion oPercepciones9 = new NominaPercepcionesPercepcion();
            oPercepciones9.ImporteExento = Convert.ToDecimal("670.26");
            oPercepciones9.ImporteGravado = Convert.ToDecimal("0.00");
            oPercepciones9.Concepto = "APORTACION GUBERNAMENTAL FONAC";
            oPercepciones9.Clave = "0F2";
            oPercepciones9.TipoPercepcion = c_TipoPercepcion.Item005;

            NominaPercepcionesPercepcion oPercepciones10 = new NominaPercepcionesPercepcion();
            oPercepciones10.ImporteExento = Convert.ToDecimal("0.00");
            oPercepciones10.ImporteGravado = Convert.ToDecimal("114.83");
            oPercepciones10.Concepto = "AYUDA POR SERVICIOS A LA CULTURA";
            oPercepciones10.Clave = "0SD";
            oPercepciones10.TipoPercepcion = c_TipoPercepcion.Item038;

            NominaDeducciones oDeducciones = new NominaDeducciones();
            oDeducciones.TotalImpuestosRetenidos = Convert.ToDecimal("847.13");
            oDeducciones.TotalOtrasDeducciones = Convert.ToDecimal("3883.74");

            NominaDeduccionesDeduccion oDeducciones1 = new NominaDeduccionesDeduccion();
            oDeducciones1.Importe = Convert.ToDecimal("847.13");
            oDeducciones1.Concepto = "IMPUESTO SOBRE LA RENTA";
            oDeducciones1.Clave = "001";
            oDeducciones1.TipoDeduccion = c_TipoDeduccion.Item002;

            NominaDeduccionesDeduccion oDeducciones2 = new NominaDeduccionesDeduccion();
            oDeducciones2.Importe = Convert.ToDecimal("248.00");
            oDeducciones2.Concepto = "SEGURO DE CESANTIA EN EDAD AVANZADA Y VEJEZ";
            oDeducciones2.Clave = "01L";
            oDeducciones2.TipoDeduccion = c_TipoDeduccion.Item003;

            NominaDeduccionesDeduccion oDeducciones3 = new NominaDeduccionesDeduccion();
            oDeducciones3.Importe = Convert.ToDecimal("25.31");
            oDeducciones3.Concepto = "SEGURO DE INVALIDEZ Y VIDA";
            oDeducciones3.Clave = "03L";
            oDeducciones3.TipoDeduccion = c_TipoDeduccion.Item001;

            NominaDeduccionesDeduccion oDeducciones4 = new NominaDeduccionesDeduccion();
            oDeducciones4.Importe = Convert.ToDecimal("20.25");
            oDeducciones4.Concepto = "SERVICIOS SOCIALES Y CULTURALES";
            oDeducciones4.Clave = "03L";
            oDeducciones4.TipoDeduccion = c_TipoDeduccion.Item001;

            NominaDeduccionesDeduccion oDeducciones5 = new NominaDeduccionesDeduccion();
            oDeducciones5.Importe = Convert.ToDecimal("136.65");
            oDeducciones5.Concepto = "SEGURO DE SALUD";
            oDeducciones5.Clave = "04L";
            oDeducciones5.TipoDeduccion = c_TipoDeduccion.Item001;

            NominaDeduccionesDeduccion oDeducciones6 = new NominaDeduccionesDeduccion();
            oDeducciones6.Importe = Convert.ToDecimal("348.66");
            oDeducciones6.Concepto = "SEGURO DE VIDA INDIVIDUAL";
            oDeducciones6.Clave = "051";
            oDeducciones6.TipoDeduccion = c_TipoDeduccion.Item004;

            NominaDeduccionesDeduccion oDeducciones7 = new NominaDeduccionesDeduccion();
            oDeducciones7.Importe = Convert.ToDecimal("1214.70");
            oDeducciones7.Concepto = "PRESTAMO HIPOT FOVISSSTE";
            oDeducciones7.Clave = "064";
            oDeducciones7.TipoDeduccion = c_TipoDeduccion.Item009;

            NominaDeduccionesDeduccion oDeducciones8 = new NominaDeduccionesDeduccion();
            oDeducciones8.Importe = Convert.ToDecimal("8.50");
            oDeducciones8.Concepto = "SEGURO DAÑOS FOVISSSTE";
            oDeducciones8.Clave = "065";
            oDeducciones8.TipoDeduccion = c_TipoDeduccion.Item009;

            NominaDeduccionesDeduccion oDeducciones9 = new NominaDeduccionesDeduccion();
            oDeducciones9.Importe = Convert.ToDecimal("7.28");
            oDeducciones9.Concepto = "SEGURO COLECTIVO DE RETIRO";
            oDeducciones9.Clave = "077";
            oDeducciones9.TipoDeduccion = c_TipoDeduccion.Item004;

            NominaDeduccionesDeduccion oDeducciones10 = new NominaDeduccionesDeduccion();
            oDeducciones10.Importe = Convert.ToDecimal("757.29");
            oDeducciones10.Concepto = "PRESTAMO PERSONAL";
            oDeducciones10.Clave = "D03";
            oDeducciones10.TipoDeduccion = c_TipoDeduccion.Item004;

            NominaDeduccionesDeduccion oDeducciones11 = new NominaDeduccionesDeduccion();
            oDeducciones11.Importe = Convert.ToDecimal("446.84");
            oDeducciones11.Concepto = "FONDO DE AHORRO CAPITALIZABLE";
            oDeducciones11.Clave = "0F0";
            oDeducciones11.TipoDeduccion = c_TipoDeduccion.Item004;

            NominaDeduccionesDeduccion oDeducciones12 = new NominaDeduccionesDeduccion();
            oDeducciones12.Importe = Convert.ToDecimal("670.26");
            oDeducciones12.Concepto = "APORTACION GUBERNAMENTAL FONAC";
            oDeducciones12.Clave = "0F1";
            oDeducciones12.TipoDeduccion = c_TipoDeduccion.Item004;


            NominaOtroPago oTropago = new NominaOtroPago();
            oTropago.Importe = Convert.ToDecimal("0.00");
            oTropago.Concepto = "CREDITO AL SALARIO";
            oTropago.Clave = "0CS";
            oTropago.TipoOtroPago = c_TipoOtroPago.Item002;

            NominaOtroPagoSubsidioAlEmpleo oSubsidio = new NominaOtroPagoSubsidioAlEmpleo();
            oSubsidio.SubsidioCausado = Convert.ToDecimal("0.00");

            AdicionalesProducto oAdicional = new AdicionalesProducto();
            oAdicional.Descuento = Convert.ToDecimal("2104.00");
            oAdicional.PorcentajeDescuento = Convert.ToDecimal("0");
            oAdicional.PorcentajeISR = Convert.ToDecimal("0.00");
            oAdicional.MontoISR = Convert.ToDecimal("0.00");
            oAdicional.PorcentajeIvar = Convert.ToDecimal("0.00");
            oAdicional.MontojeIvar = Convert.ToDecimal("0.00");
            oAdicional.PorcentajeIEPS = Convert.ToDecimal("0.00");
            oAdicional.MontoIEPS = Convert.ToDecimal("0.00");
            oAdicional.PorcentajeIva = Convert.ToDecimal("0.00");
            oAdicional.MontojeIva = Convert.ToDecimal("0.00");
            oAdicional.NumeroProducto = Convert.ToDecimal("1");
            oAdicional.NumeroFactura = Convert.ToDecimal("138");

            Enviara oEnviara = new Enviara();
            oEnviara.NumeroFactura = Convert.ToDecimal("138");




            oNomina.Comprobante = oComprobante;
            oNomina.ComprobanteEmisor = oComprobanteEmisor;
            oNomina.ComprobanteReceptor = oComprobanteReceptor;
            oNomina.Conceptos = oConceptos;
            oNomina.Complemento = oComplemento;
            oNomina.Emisor = oEmisor;
            oNomina.Receptor = oReceptor;
            oNomina.Percepciones = oPercepciones;






            //creamos xml


            string cadenaoriginal = "";
            string direccion = Directory.GetCurrentDirectory();
            string pathxsl = direccion+"cadenaoriginal_3_3.xslt";
            System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
            transformador.Load(pathxsl);

            using (StringWriter sw = new StringWriter())
            using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
            {
                transformador.Transform(pathXML, xwo);
                cadenaoriginal = sw.ToString();
            }

            XSDToXML.Utils.SelloDigital oselloDigital = new XSDToXML.Utils.SelloDigital();
            oComprobante.Certificado = oselloDigital.Certificado(phatcer);
            oComprobante.Sello = oselloDigital.Sellar(cadenaoriginal, phatkey, claveprivada);
            oComplemento.SelloSat = oselloDigital.Sellar(cadenaoriginal, phatkey, claveprivada);
            oComplemento.SelloCFD = oselloDigital.Sellar(cadenaoriginal, phatkey, claveprivada);

            Createxml(oNomina);

            //timbrar
           // ServiceReference1.RespuestaCFDi respuestaCFDI = new ServiceReference1.RespuestaCFDi();
            //byte[] bXML = System.IO.File.ReadAllBytes(pathXML);
            //ServiceReference1.TimbradoClient oTimbrado = new ServiceReference1.TimbradoClient();
            //respuestaCFDI = oTimbrado.TimbrarTest("TEST010101ST1", "aaaaaa", bXML);
            //if (respuestaCFDI.Documento == null)
           // {
              //  MessageBox.Show(respuestaCFDI.Mensaje);
           // }
           // else
            //{
              //  System.IO.File.WriteAllBytes(pathXML, respuestaCFDI.Documento);
            //}


        }
        private static void Createxml(Nomina oNomina)
        {
            //SERIALIZAMOS.-------------------------------------------------



            XmlSerializer oXmlSerializar = new XmlSerializer(typeof(Nomina));

            string sXml = "";

            using (var sww = new XSDToXML.Utils.StringWriterWithEncoding(Encoding.UTF8))
            {
                using (XmlWriter writter = XmlWriter.Create(sww))
                {

                    oXmlSerializar.Serialize(writter, oNomina);
                    sXml = sww.ToString();
                }

            }

            //guardamos el string en un archivo
            System.IO.File.WriteAllText(pathXML, sXml);
            MessageBox.Show("XML GENERADO");
        }
    }
}
