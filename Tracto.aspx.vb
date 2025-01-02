Imports System.Data
Imports System.Xml
Partial Class DataProviders_Tracto
    Inherits System.Web.UI.Page
    Shared strSeparador1Paso As String = "ý"
    Shared strSeparador2Paso As String = "ü"
    Shared strSeparador3Paso As String = "@"

    Shared NERROR As Integer = 0
    Shared VERSION As Integer = 1
    Shared TIPOTRANSACCION As Integer = 2
    Shared COTIZACION As Integer = 3
    Shared NEGOCIO As Integer = 4
    Shared TIPONEGOCIO As Integer = 5

    Shared VEHICULO_ID As Integer = 10
    Shared VEHICULO_AMIS As Integer = 11
    Shared VEHICULO_MODELO As Integer = 12
    Shared VEHICULO_DESCRIPCION As Integer = 13
    Shared VEHICULO_USO As Integer = 14
    Shared VEHICULO_SERVICIO As Integer = 15
    Shared VEHICULO_PLAN As Integer = 16
    Shared VEHICULO_MOTOR As Integer = 17
    Shared VEHICULO_SERIE As Integer = 18
    Shared VEHICULO_REPUVE As Integer = 19
    Shared VEHICULO_PLACAS As Integer = 20
    Shared VEHICULO_CONDUCTOR As Integer = 21
    Shared VEHICULO_CONDUCTOR_LICENCIA As Integer = 22
    Shared VEHICULO_CONDUCTOR_FECNAC As Integer = 23
    Shared VEHICULO_CONDUCTOR_OCUPACION As Integer = 24
    Shared VEHICULO_ESTADO As Integer = 25
    Shared VEHICULO_POBLACION As Integer = 26
    Shared VEHICULO_COLOR As Integer = 27
    Shared VEHICULO_DISPOSITIVO As Integer = 28
    Shared VEHICULO_FECDISPOSITIVO As Integer = 29
    Shared VEHICULO_TIPOCARGA As Integer = 30
    Shared VEHICULO_TIPOCARGA_DESCRIPCION As Integer = 31

    Shared VEHICULO_COBERTURA_ID As Integer = 32
    Shared VEHICULO_COBERTURA_DESC As Integer = 33
    Shared VEHICULO_COBERTURA_SA As Integer = 34
    Shared VEHICULO_COBERTURA_TIPO As Integer = 35
    Shared VEHICULO_COBERTURA_DED As Integer = 36
    Shared VEHICULO_COBERTURA_PMA As Integer = 37

    Shared VEHICULO_COBERTURA_ARGUMENTO_ID As Integer = 38
    Shared VEHICULO_COBERTURA_ARGUMENTO_TIPO As Integer = 39
    Shared VEHICULO_COBERTURA_ARGUMENTO_CAMPO As Integer = 40
    Shared VEHICULO_COBERTURA_ARGUMENTO_VALOR As Integer = 41

    Shared VEHICULO_ARGUMENTO_ID As Integer = 42
    Shared VEHICULO_ARGUMENTO_TIPO As Integer = 43
    Shared VEHICULO_ARGUMENTO_CAMPO As Integer = 44
    Shared VEHICULO_ARGUMENTO_VALOR As Integer = 45

    Shared ASEGURADO_ID As Integer = 50
    Shared ASEGURADO_NOMBRE As Integer = 51
    Shared ASEGURADO_PATERNO As Integer = 52
    Shared ASEGURADO_MATERNO As Integer = 53
    Shared ASEGURADO_CALLE As Integer = 54
    Shared ASEGURADO_NUMEROINTERIOR As Integer = 55
    Shared ASEGURADO_NUMEROEXTERIOR As Integer = 56
    Shared ASEGURADO_COLONIA As Integer = 57
    Shared ASEGURADO_POBLACION As Integer = 58
    Shared ASEGURADO_ESTADO As Integer = 59
    Shared ASEGURADO_CODIGOPOSTAL As Integer = 60
    Shared ASEGURADO_PAIS As Integer = 61
    Shared ASEGURADO_TIPOPERSONA As Integer = 62
    Shared ASEGURADO_ARGUMENTO_ID As Integer = 63
    Shared ASEGURADO_ARGUMENTO_TIPO As Integer = 64
    Shared ASEGURADO_ARGUMENTO_CAMPO As Integer = 65
    Shared ASEGURADO_ARGUMENTO_VALOR As Integer = 66

    Shared POLIZA_ID As Integer = 70
    Shared POLIZA_TIPO As Integer = 71
    Shared POLIZA_ENDOSO As Integer = 72
    Shared POLIZA_FECEMISION As Integer = 73
    Shared POLIZA_FECINICIOVIG As Integer = 74
    Shared POLIZA_FECTERMINOVIG As Integer = 75
    Shared POLIZA_MONEDA As Integer = 76
    Shared POLIZA_BONIFICACION As Integer = 77
    Shared POLIZA_FORMAPAGO As Integer = 78
    Shared POLIZA_AGENTE As Integer = 79
    Shared POLIZA_TARIFACUOTA As Integer = 80
    Shared POLIZA_TARIFAVALORES As Integer = 81
    Shared POLIZA_TARIFADERECHOS As Integer = 82
    Shared POLIZA_BENEFICIARIO As Integer = 83
    Shared POLIZA_POLITICACANCCELACION As Integer = 84

    Shared POLIZA_ARGUMENTO_ID As Integer = 85
    Shared POLIZA_ARGUMENTO_TIPO As Integer = 86
    Shared POLIZA_ARGUMENTO_CAMPO As Integer = 87
    Shared POLIZA_AARGUMENTO_VALOR As Integer = 88

    Shared PRIMA_PRIMANETA As Integer = 90
    Shared PRIMA_DERECHO As Integer = 91
    Shared PRIMA_RECARGO As Integer = 92
    Shared PRIMA_IMPUESTO As Integer = 93
    Shared PRIMA_PRIMATOTAL As Integer = 94
    Shared PRIMA_COMISION As Integer = 95

    Shared RECIBO_ID As Integer = 100
    Shared RECIBO_FECINICIOVIG As Integer = 101
    Shared RECIBO_FECTERMINOVIG As Integer = 102
    Shared RECIBO_PRIMANETA As Integer = 103
    Shared RECIBO_DERECHO As Integer = 104
    Shared RECIBO_RECARGO As Integer = 105
    Shared RECIBO_IMPUESTO As Integer = 106
    Shared RECIBO_PRIMATOTAL As Integer = 107
    Shared RECIBO_COMISION As Integer = 108
    Shared RECIBO_CADENAORIGINAL As Integer = 109
    Shared RECIBO_SELLODIGITAL As Integer = 110
    Shared RECIBO_FECEMISION As Integer = 111
    Shared RECIBO_SERIE As Integer = 112
    Shared RECIBO_FOLIO As Integer = 113
    Shared RECIBO_HORAEMISION As Integer = 114
    Shared RECIBO_NUMEROAPROBACION As Integer = 115
    Shared RECIBO_ANOAPROVACION As Integer = 116
    Shared RECIBO_NUMSERIECERTIFICADO As Integer = 117
    Shared RECIBO_ARGUMENT_ID As Integer = 118
    Shared RECIBO_ARGUMENTO_TIPO As Integer = 119
    Shared RECIBO_ARGUMENTO_CAMPO As Integer = 120
    Shared RECIBO_ARGUMENTO_VALOR As Integer = 121

    Protected strCoberturaDet1 As String = ""
    Protected strCoberturaDet2 As String = ""
    Protected strCoberturaDet3 As String = ""
    Protected strCoberturaDet4 As String = ""
    Protected strCoberturaDet5 As String = ""
    Protected strCoberturaDet6 As String = ""

    Protected strCoberturaDet11 As String = ""
    Protected strCoberturaDet21 As String = ""
    Protected strCoberturaDet31 As String = ""
    Protected strCoberturaDet41 As String = ""
    Protected strCoberturaDet51 As String = ""
    Protected strCoberturaDet61 As String = ""

    Protected BotonInicio As String = ""
    Protected BotonCotizar As String = ""
    Protected Fondo As String = ""
    Protected Contactanos As String = ""
    Protected LogoCliente As String = ""
    Protected LogoCentral As String = ""
    'Protected Noticias As String = ""
    Protected Separadores As String = ""

    Protected TempXprimaNeta As String = ""
    Protected TempXderecho As String = ""
    Protected TempXrecargo As String = ""
    Protected TempXimpuesto As String = ""
    Protected TempXprimaTotal As String = ""
    Private DBError As String = ""

    Private FuncionesTransaccion As New ANANet.Transaccion
    Protected Funciones As New ANANet.Funciones
    Public Property cmbDeducibleRCEco As Object

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim Respuesta As New System.Text.StringBuilder

        Respuesta.Append("var Validacion = new Array(); ")

        If Request("servicio") IsNot Nothing Then
            EjecutaServicio(Request, Respuesta)
        End If

        Response.Write(Respuesta.ToString)

    End Sub
    Private Sub EjecutaServicio(ByVal solicitud As HttpRequest, ByRef respuesta As System.Text.StringBuilder)
        Dim Servicio As String = solicitud("servicio")
        Dim Validacion As Boolean = True
        Dim DescripcionError As String = String.Empty
        Dim jsCode As String = String.Empty

        Select Case Servicio
            Case "ConsultaSession"
                Dim jsRespuesta As String = "var vbSession = false;"

                If Session("nIdUsuario") IsNot Nothing Then
                    Session("nIdUsuario") = Session("nIdUsuario")
                    jsRespuesta &= "vbSession = true; "
                End If

                respuesta.Append(jsRespuesta)

            Case "ConsultaUsuario"
                Dim cLlave As String = solicitud("cLlave")
                Dim cUsuario As String = solicitud("cUsuario")
                Dim cPassword As String = solicitud("cPassword")

                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)

                Dim dtUsuario As DataTable = FuncionesTransaccion.GetUsuario(nIdNegocio, cUsuario, cPassword, DBError)
                Dim JsUsuario As String = "var vbUsuario = false;"

                If dtUsuario.Rows.Count > 0 Then
                    JsUsuario &= "vbUsuario = true;"
                End If

                respuesta.Append(JsUsuario)

            Case "ConstruyeNegocio"
                Dim strLlave As String = solicitud("cLlave")
                Dim JsEval As String = ""
                Dim strError As String = ""

                Dim strPresenta As String = "0"
                Dim CargaParametrosNegocio As Boolean = True
                Dim nIdNegocio As Long = 0
                Try
                    'strPresenta = Request.QueryString("P")
                    If strLlave Is Nothing Then
                        strLlave = ""
                    End If
                    nIdNegocio = FuncionesTransaccion.GetIdNegocio(strLlave, strError)
                    If nIdNegocio > 0 Then
                        'lblIdNegocio.Text = negocioID
                    Else
                        JsEval &= "Tractos.Mensaje('Lo sentimos el negocio no existe, favor de verificar. gracias', 100, 100); "
                    End If

                Catch ex As Exception
                    JsEval &= "Tractos.Mensaje('Lo sentimos el negocio no existe, favor de verificar. gracias', 100, 100); "
                    GoTo 100
                End Try

                Dim dsNegocio As DataSet = FuncionesTransaccion.GetNegocio(nIdNegocio, strError)

                With dsNegocio.Tables(0).Rows(0)
                    If .Item("nTractos") > 0 Then
                        If .Item("nEstatus") = 1 Then
                            '[MSG] no se ocupa en el proceso
                            'JsEval &= "Tractos.parametros.nTipoCotizacion = " & .Item("nTipoCotizacion") & "; "
                            'Dim dsTipoVehiculo As DataSet = FuncionesTransaccion.GetTipoVehiculo(nIdNegocio, strError)
                            Dim nMoneda As Integer = 0
                            Dim strSQL As String = ""

                            CargaModelo(0, nIdNegocio, JsEval)
                            Dim dsEstado As DataSet = FuncionesTransaccion.GetEstado(nIdNegocio, strError)

                            Dim dsColor As DataSet = FuncionesTransaccion.GetColor(DBError)

                            For i As Integer = 0 To dsColor.Tables(0).Rows.Count - 1
                                strSQL &= "<option value='" & dsColor.Tables(0).Rows(i).Item("nIdColor") & "'>" & dsColor.Tables(0).Rows(i).Item("cColor").Replace("<", "-- ").Replace(">", " --") & "</option>"
                            Next

                            JsEval &= "$('#CmbColor').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            strSQL = ""
                            For i As Integer = 0 To dsEstado.Tables(0).Rows.Count - 1
                                strSQL &= "<option value='" & dsEstado.Tables(0).Rows(i).Item("nIdEstado") & "'>" & dsEstado.Tables(0).Rows(i).Item("cEstado") & "</option>"
                            Next
                            JsEval &= "$('#CmbEstado').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            CargaMunicipio(1, JsEval)

                            Select Case Val(.Item("cMoneda"))
                                Case 0
                                    strSQL = "<option value='00'>NACIONAL</option>"
                                Case 1
                                    strSQL = "<option value='01'>DOLARES</option>"
                                    nMoneda = 1
                                Case 2
                                    strSQL = "<option value='00'>NACIONAL</option><option value='01' >DOLARES</option>"
                                Case 3
                                    strSQL = "<option value='00'>NACIONAL</option><option value='01' >DOLARES</option>"
                                Case 4
                                    strSQL = "<option value='00'>NACIONAL</option>"
                            End Select

                            JsEval &= "$('#CmbMoneda').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            Dim Year As Integer = Date.Now.Year
                            Dim ArrCombo As String = ""
                            For i As Integer = 0 To 10
                                ArrCombo &= "<option value='" & Year & "'>" & Year & "</option>"
                                Year += 1
                            Next

                            JsEval &= "$('#CmbAno').html('" & ArrCombo.Replace("'", Chr(34)) & "'); "

                            Dim ArrTipoPoliza() As String = .Item("cTipoDePolizaT").ToString.Split("|")

                            strSQL = ""
                            For i As Integer = 0 To ArrTipoPoliza.Length - 1
                                Select Case ArrTipoPoliza(i)
                                    Case "A"
                                        strSQL &= "<option value='2'>ANUAL</option>"
                                    Case "M"
                                        strSQL &= "<option value='0'>MULTIANUAL</option>"
                                    Case "P"
                                        strSQL &= "<option value='1'>POLIANUAL</option>"
                                End Select
                            Next

                            JsEval &= "$('#CmbTipoPoliza').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            strSQL = ""
                            Select Case .Item("nFormaPagoT")
                                Case 0
                                    strSQL &= "<option value='0'>Tarjeta de Credito</option>"
                                    strSQL &= "<option value='1'>Efectivo</option>"
                                Case 1
                                    strSQL &= "<option value='0'>Tarjeta de Credito</option>"
                                Case 2
                                    strSQL &= "<option value='1'>Efectivo</option>"
                            End Select

                            JsEval &= "$('#CmbTipoPago').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            If Not .IsNull("cDeducibleDanos") Then
                                Dim strValores() As String = .Item("cDeducibleDanos").ToString.Split("|")
                                strSQL = ""
                                For i As Integer = 0 To strValores.Length - 1
                                    If strValores(i).Trim.Length > 0 Then
                                        strSQL &= "<option value='" & strValores(i) & "'>" & strValores(i) & "</option>"
                                    End If
                                Next
                                JsEval &= "$('#CmbDD').html('" & strSQL.Replace("'", Chr(34)) & "'); "
                                JsEval &= "$('#CmbDD').val('" & .Item("nDefaultDD") & "'); "
                            Else
                            End If

                            If Not .IsNull("cDeducibleRobo") Then
                                Dim strValores() As String = .Item("cDeducibleRobo").ToString.Split("|")
                                strSQL = ""
                                For i As Integer = 0 To strValores.Length - 1
                                    If strValores(i).Trim.Length > 0 Then
                                        strSQL &= "<option value='" & strValores(i) & "'>" & strValores(i) & "</option>"
                                    End If
                                Next
                                JsEval &= "$('#CmbDR').html('" & strSQL.Replace("'", Chr(34)) & "'); "
                                JsEval &= "$('#CmbDR').val('" & .Item("nDefaultDR") & "'); "
                            Else
                            End If

                            Dim dsGiro As DataSet = FuncionesTransaccion.getGiro(nIdNegocio, DBError)

                            If dsGiro.Tables(0).Rows.Count > 0 Then
                                strSQL = ""
                                For i As Integer = 0 To dsGiro.Tables(0).Rows.Count - 1
                                    If i = 0 Then
                                        strSQL &= "<option value='0'>-- SELECCIONAR --</option>"
                                    Else
                                        strSQL &= "<option value='" & dsGiro.Tables(0).Rows(i).Item("nIdGiroEmpresa") & "'>" & dsGiro.Tables(0).Rows(i).Item("cGiroEmpresa") & "</option>"
                                    End If

                                Next
                                JsEval &= "$('#CmbGiro').html('" & strSQL.Replace("'", Chr(34)) & "'); "
                            End If

                            Dim dsTractos As DataSet = FuncionesTransaccion.Query("SELECT a.nIdArmadoraTracto, cArmadoraTracto FROM armadoratracto a, wsnegocioarmadoratracto b WHERE a.nIdArmadoraTracto = b.nIdArmadoraTracto AND nIdNegocio = " & nIdNegocio & " ORDER BY a.cArmadoraTracto", "")
                            strSQL = ""
                            For i As Integer = 0 To dsTractos.Tables(0).Rows.Count - 1
                                strSQL &= "<option value='" & dsTractos.Tables(0).Rows(i).Item("nIdArmadoraTracto") & "'>" & dsTractos.Tables(0).Rows(i).Item("cArmadoraTracto") & "</option>"
                            Next
                            JsEval &= "$('#CmbMarca').html('" & strSQL.Replace("'", Chr(34)) & "'); "

                            strSQL = ""
                            If nIdNegocio = 986 Then
                                strSQL &= "<option value='50000506 TRACTOCAMION'>50000506 TRACTOCAMION 2 PTS 12 CIL STD AUT</option>"
                                strSQL &= "<option value='60000606 SEMIREMOLQUE INDISTINTO'>60000606 SEMIREMOLQUE INDISTINTO</option>"
                                strSQL &= "<option value='60000607 DOLLY'>60000607 DOLLY</option>"
                                strSQL &= "<option value='60000608 SEMIREMOLQUE'>60000608 SEMIREMOLQUE</option>"
                            Else
                                If nIdNegocio = 987 Then
                                    strSQL &= "<option value='11000103 CAMION 1.5 TON 2 PTS 6 CL STD'>11000103 CAMION 1.5 TON 2 PTS 6 CL STD</option>"
                                    strSQL &= "<option value='20000204 CAMION 3.5 TON 2 PTS 6 CL STD'>20000204 CAMION 3.5 TON 2 PTS 6 CL STD</option>"
                                    strSQL &= "<option value='30000302 CAMION 7.5 TON 2 PTS 6 CL STD'>30000302 CAMION 7.5 TON 2 PTS 6 CL STD</option>"
                                    strSQL &= "<option value='40000404 RABON'>40000404 RABON 14 TON (HASTA 14 TON) 2 PTS 8 CIL STD</option>"
                                    strSQL &= "<option value='50000505 THORTON'>50000505 THORTON 14 TON (MAS 14 TON) 2 PTS 10 CIL STD</option>"
                                    strSQL &= "<option value='50000507 TANDEM'>50000507 TANDEM (MAS 14 TON) 2 PTS 10 CIL STD</option>"
                                Else
                                    strSQL &= "<option value='50000602 GN TRACTOCAMION'>50000602 GN TRACTOCAMION</option>"
                                End If
                            End If


                            'strSQL = ""
                            'strSQL &= "<option value='11000103 CAMION 1.5 TON 2 PTS 6 CL STD'>11000103 CAMION 1.5 TON 2 PTS 6 CL STD</option>"
                            'strSQL &= "<option value='20000204 CAMION 3.5 TON 2 PTS 6 CL STD'>20000204 CAMION 3.5 TON 2 PTS 6 CL STD</option>"
                            'strSQL &= "<option value='30000302 CAMION 7.5 TON 2 PTS 6 CL STD'>30000302 CAMION 7.5 TON 2 PTS 6 CL STD</option>"
                            'strSQL &= "<option value='40000404 RABON'>40000404 RABON 14 TON (HASTA 14 TON) 2 PTS 8 CIL STD</option>"
                            'strSQL &= "<option value='50000505 THORTON'>50000505 THORTON 14 TON (MAS 14 TON) 2 PTS 10 CIL STD</option>"
                            'strSQL &= "<option value='50000506 TRACTOCAMION'>50000506 TRACTOCAMION 2 PTS 12 CIL STD AUT</option>"
                            'strSQL &= "<option value='50000507 TANDEM'>50000507 TANDEM (MAS 14 TON) 2 PTS 10 CIL STD</option>"
                            'strSQL &= "<option value='60000606 SEMIREMOLQUE INDISTINTO'>60000606 SEMIREMOLQUE INDISTINTO</option>"
                            'strSQL &= "<option value='60000607 DOLLY'>60000607 DOLLY</option>"
                            'strSQL &= "<option value='60000608 SEMIREMOLQUE'>60000608 SEMIREMOLQUE</option>"

                            JsEval &= "$('#CmbSubMarca').html('" & strSQL.Replace("'", Chr(34)) & "'); "
                            cargaNuevosCombos(nMoneda, dsNegocio.Tables(0), JsEval)


                            ''                       0)Moneda                 1)tarifa valores,        2)tarifa coutas,                   3)tarifa derechos,               4)agente,              5)politica compensacion          6) VALOR MAXIMO                        7) Llave negocio 8) negocio especial                    9) valor factura                   10) solicitud               11) correo solicitud                                                  12) Quincenas               13) dato adicional            14) requeridos grupo 1           15) requeridos grupo 1          16) negocio
                            JsEval &= "Tractos.parametros.strValores = '" & .Item("cMoneda") & "|" & .Item("cTarifaCuota") & "|" & .Item("cTarifaValor") & "|" & .Item("cTarifaDerecho") & "|" & .Item("cAgente") & "|" & .Item("cPolitcaCompensacion") & "|" & .Item("nMaximoSumaAsegurada") & "|" & .Item("cLlave") & "|" & .Item("nNegocioEspecial") & "|" & .Item("nValorFactura") & "|" & .Item("nSolicitud") & "|" & IIf(.IsNull("cCorreoSolicitud"), "", .Item("cCorreoSolicitud")) & "|" & .Item("nQuincenas") & "|" & .Item("nDatoAgencia") & "|" & .Item("nCampoRequerido1") & "|" & .Item("nCampoRequerido2") & "|" & .Item("nIdNegocio") & "'; "
                            JsEval &= "Tractos.parametros.nTipoCobranza = " & .Item("nCobroEnLinea") & "; "
                            JsEval &= "Tractos.parametros.cUsuarioSeg = '" & .Item("cUsuario") & "'; "
                            JsEval &= "Tractos.parametros.cClaveSeg = '" & .Item("cClave") & "'; "
                            JsEval &= "Tractos.parametros.nAdaptacion = '" & .Item("nValorMaxAdaptacionT") & "'; "
                            JsEval &= "Tractos.parametros.nDescuento = '" & .Item("nDescuento") & "'; "
                            JsEval &= "Tractos.parametros.nRecargo = '" & .Item("nRecargoN") & "'; "
                            JsEval &= "Tractos.parametros.nDiasRetro = '" & .Item("nDiasRetro") & "'; "
                            JsEval &= "Tractos.parametros.nDiasAnticipada = '" & .Item("nDiasAnticipada") & "'; "

                            Select Case .Item("nValorFacturaT")
                                Case 0
                                    JsEval &= "$('#ChkVF').iCheck('uncheck');"
                                Case 1
                                    JsEval &= "$('#ChkVF').iCheck('check');"
                                Case 2
                                    JsEval &= "$('#ChkVF').iCheck('uncheck').iCheck('disable');"
                                Case 4
                                    JsEval &= "$('#ChkVF').iCheck('check').iCheck('disable');"
                            End Select

                            CargaVigencia(JsEval, 2, nIdNegocio)
                        Else
                            JsEval &= "Tractos.Mensaje('Lo sentimos el negocio esta desactivado, favor de verificar. gracias', 100, 100); $('#Cotizar').hide(); "
                        End If
                    Else
                        JsEval &= "Tractos.Mensaje('Lo sentimos el negocio no pertenece al ramo de tractos, favor de verificar. gracias', 100, 100); $('#Cotizar').hide(); "
                    End If

                End With


100:            respuesta.Append(JsEval)

            Case "CargaModelo"
                Dim nValorFactura As String = solicitud("nValorFactura")
                Dim cLlave As String = solicitud("cLlave")
                Dim JsEval As String = ""
                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)

                CargaModelo(nValorFactura, nIdNegocio, JsEval)

                respuesta.Append(JsEval)

            Case "CargaVigencia"
                Dim nTipoPoliza As String = solicitud("nTipoPoliza")
                Dim cLlave As String = solicitud("cLlave")
                Dim JsEval As String = ""
                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)

                CargaVigencia(JsEval, nTipoPoliza, nIdNegocio)

                respuesta.Append(JsEval)

            Case "cargaNuevosCombos"
                Dim Moneda As String = solicitud("Moneda")
                Dim cLlave As String = solicitud("cLlave")
                Dim JsEval As String = ""
                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)

                Dim dsNegocio As DataSet = FuncionesTransaccion.GetNegocio(nIdNegocio, DBError)
                cargaNuevosCombos(Moneda, dsNegocio.Tables(0), JsEval)

                respuesta.Append(JsEval)
            Case "CargaMunicipio"
                Dim nEstado As String = solicitud("nEstado")
                Dim JsEval As String = ""

                Dim dsMunicipio As DataSet = FuncionesTransaccion.GetMunicipio(nEstado, DBError)

                For i As Integer = 0 To dsMunicipio.Tables(0).Rows.Count - 1
                    JsEval &= "<option value='" & dsMunicipio.Tables(0).Rows(i).Item("nIdMunicipio") & "'>" & dsMunicipio.Tables(0).Rows(i).Item("cMunicipio") & "</option>"
                Next

                JsEval = "$('#cmbMunicipio').html('" & JsEval.Replace("'", Chr(34)) & "'); "

                respuesta.Append(JsEval)

            Case "CargaCodigoPostal"
                Dim nMunicipio As String = solicitud("nMunicipio")
                Dim nEstado As String = solicitud("nEstado")
                Dim JsEval As String = ""

                Dim dsCP As DataSet = FuncionesTransaccion.getCodigoPostal(nEstado, nMunicipio, DBError)

                For i As Integer = 0 To dsCP.Tables(0).Rows.Count - 1
                    JsEval &= "<option value='" & dsCP.Tables(0).Rows(i).Item("cCodigo") & "'>" & dsCP.Tables(0).Rows(i).Item("cCodigo") & "</option>"
                Next

                JsEval = "$('#CmbCodigoPostal').html('" & JsEval.Replace("'", Chr(34)) & "'); "

                respuesta.Append(JsEval)

            Case "CargaColonia"
                Dim nMunicipio As String = solicitud("nMunicipio")
                Dim nEstado As String = solicitud("nEstado")
                Dim cCodigoPostal As String = solicitud("cCodigoPostal")
                Dim JsEval As String = ""

                Dim dsCP As DataSet = FuncionesTransaccion.getColonia(nEstado, nMunicipio, cCodigoPostal, DBError)

                For i As Integer = 0 To dsCP.Tables(0).Rows.Count - 1
                    JsEval &= "<option value='" & dsCP.Tables(0).Rows(i).Item("nColonia") & "'>" & dsCP.Tables(0).Rows(i).Item("cColonia") & "</option>"
                Next

                JsEval = "$('#CmbColonia').html('" & JsEval.Replace("'", Chr(34)) & "'); "

                respuesta.Append(JsEval)

            Case "Cotizar"
                Dim nPaquete As String = 1
                Dim cLlave As String = solicitud("cLlave")
                Dim cTipo As String = solicitud("cTipo")

                Dim cPrimaTotal As String = ""
                Dim nRecibos As Double = 0
                Dim cRecibo As String = ""
                Dim cReciboSub As String = ""

                Dim strXML As String = ""
                Dim strPaquete As String = ""
                Dim dInicio As Date = Now.Date
                Dim dTermino As Date = Now.Date
                Dim strCoberturas As String = ""
                Dim servicioANA As New wsANA.Service

                Dim cFormaPago As String = solicitud("cFormaPago")
                Dim cSubMarca() As String = solicitud("cSubmarca").Split(" ")
                Dim cAMIS As String = cSubMarca(0)
                Dim nModelo As String = solicitud("nModelo")
                Dim cEstado As String = Long.Parse(solicitud("nEstado")).ToString("00") & Long.Parse(solicitud("nMunicipio")).ToString("000")
                Dim motor As String = ""
                Dim serie As String = ""
                Dim placas As String = ""
                Dim conductor As String = ""
                Dim conductorliciencia As String = ""
                Dim conductorfecnac As String = ""
                Dim conductorocupacion As String = ""
                Dim nombre As String = ""
                Dim paterno As String = ""
                Dim materno As String = ""
                Dim calle As String = ""
                Dim numerointerior As String = ""
                Dim numeroexterior As String = ""
                Dim colonia As String = ""
                Dim poblacion As String = ""
                Dim cp As String = ""
                Dim pais As String = ""
                Dim tipopersona As String = ""
                Dim correo As String = ""
                Dim cTelefono As String = ""
                Dim cRFC As String = ""
                Dim cNacionalidad As String = ""
                Dim nTipoIdentificacion As String = ""
                Dim nIdentificacion As String = ""
                Dim cOcupacion As String = ""
                Dim cFiel As String = ""
                Dim dNacimiento As String = ""
                Dim articulo140 As String = ""
                Dim cPais As String = ""
                Dim nGiro As String = ""
                Dim cAdministrador As String = ""
                Dim cFechaTH As String = ""
                Dim cRepresentante As String = ""
                Dim cNacionalidadRepres As String = ""
                Dim complementoTarjetaCredito As String = ""
                Dim cNomTarjet As String = ""
                Dim nTarjeta As String = ""
                Dim cMes As String = ""
                Dim cAño As String = ""
                Dim cCodSeg As String = ""
                Dim cBanco As String = ""
                Dim cDireccionTH As String = ""
                Dim cComprobante As String = ""
                Dim cRFCDom As String = ""
                Dim cFactura As String = ""
                Dim JsEval As String = ""
                Dim nTipoPago As String = solicitud("nTipoPago")
                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)
                Dim dtNegocio As DataTable = FuncionesTransaccion.GetNegocio(nIdNegocio, DBError).Tables(0)
                Dim cRazon As String = solicitud("cRazon")
                Dim cEmail As String = solicitud("cEmail")
                Dim cCURP As String = solicitud("cCURP")
                Dim cAdaptaciones As String = solicitud("cAdaptaciones").TrimEnd("|"c)
                Dim nRecargo As String = solicitud("nRecargo")
                Dim cNacionalidadA As String = ""
                Dim cBeneficiario As String = ""
                Dim nColor As String = solicitud("nColor")
                If cTipo = "E" Then
                    cBeneficiario = IIf(solicitud("cBeneficiarioPreferente") = Nothing, "", solicitud("cBeneficiarioPreferente").ToString.ToUpper)
                    motor = IIf(solicitud("cMotor") = Nothing, "", solicitud("cMotor").ToString.ToUpper)
                    serie = IIf(solicitud("cSerie") = Nothing, "", solicitud("cSerie").ToString.ToUpper)
                    placas = IIf(solicitud("cPlacas") = Nothing, "", solicitud("cPlacas").ToString.ToUpper)
                    conductor = IIf(solicitud("cConductor") = Nothing, "", solicitud("cConductor").ToString.ToUpper)
                    conductorliciencia = IIf(solicitud("cLicenciaConductor") = Nothing, "", solicitud("cLicenciaConductor").ToString.ToUpper)
                    conductorfecnac = IIf(solicitud("cNacimientoConductor") = Nothing, "", solicitud("cNacimientoConductor").ToString.ToUpper)
                    conductorocupacion = IIf(solicitud("cOcupacion") = Nothing, "", solicitud("cOcupacion").ToString.ToUpper)
                    nombre = IIf(solicitud("cNombre") = Nothing, "", solicitud("cNombre").ToString.ToUpper) '
                    paterno = IIf(solicitud("cPaterno") = Nothing, "", solicitud("cPaterno").ToString.ToUpper)
                    materno = IIf(solicitud("cMaterno") = Nothing, "", solicitud("cMaterno").ToString.ToUpper)
                    calle = IIf(solicitud("cCalle") = Nothing, "", solicitud("cCalle").ToString.ToUpper)
                    numerointerior = IIf(solicitud("cNoInt") = Nothing, "", solicitud("cNoInt").ToString.ToUpper)
                    numeroexterior = IIf(solicitud("cNoExt") = Nothing, "", solicitud("cNoExt").ToString.ToUpper)
                    colonia = IIf(solicitud("cColonia") = Nothing, "", solicitud("cColonia").ToString.ToUpper)
                    poblacion = "POBLACION" 'IIf(solicitud("cNombre"), "", solicitud("cNombre").ToString.ToUpper)
                    cp = IIf(solicitud("cCodigoPostal") = Nothing, "", solicitud("cCodigoPostal").ToString.ToUpper)
                    pais = "MEXICO"
                    tipopersona = IIf(solicitud("nTipoPersona") = Nothing, "1", solicitud("nTipoPersona").ToString.ToUpper)

                    correo = IIf(solicitud("cEmail") = Nothing, "", solicitud("cEmail").ToString.ToUpper)
                    cTelefono = IIf(solicitud("cTelefono") = Nothing, "", solicitud("cTelefono").ToString.ToUpper)
                    cRFC = IIf(solicitud("cRFC") = Nothing, "", solicitud("cRFC").ToString.ToUpper)
                    cNacionalidad = IIf(solicitud("cNacionalidad") = Nothing, "", solicitud("cNacionalidad").ToString.ToUpper)
                    nTipoIdentificacion = IIf(solicitud("nTipoIdentificacion") = Nothing, "", solicitud("nTipoIdentificacion").ToString.ToUpper)
                    nIdentificacion = IIf(solicitud("nIdentificacion") = Nothing, "", solicitud("nIdentificacion").ToString.ToUpper)
                    cOcupacion = IIf(solicitud("cOcupacion") = Nothing, "", solicitud("cOcupacion").ToString.ToUpper)
                    cFiel = IIf(solicitud("cFiel") = Nothing, "", solicitud("cFiel").ToString.ToUpper)
                    dNacimiento = IIf(solicitud("cFecNaci") = Nothing, "", solicitud("cFecNaci").ToString.ToUpper)
                    cPais = IIf(solicitud("cPais") = Nothing, "", solicitud("cPais").ToString.ToUpper)
                    nGiro = IIf(solicitud("nGiro") = Nothing, "", solicitud("nGiro").ToString.ToUpper)
                    cAdministrador = IIf(solicitud("cAdministrador") = Nothing, "", solicitud("cAdministrador").ToString.ToUpper)
                    cNacionalidadA = IIf(solicitud("cNacionalidadA") = Nothing, "", solicitud("cNacionalidadA").ToString.ToUpper)
                    'cFechaTH = IIf(solicitud("cFechaTH") = Nothing, "", solicitud("cFechaTH").ToString.ToUpper)
                    cRepresentante = IIf(solicitud("cRepresentante") = Nothing, "", solicitud("cRepresentante").ToString.ToUpper)
                    cNacionalidadRepres = IIf(solicitud("cNacionalidadR") = Nothing, "", solicitud("cNacionalidadR").ToString.ToUpper)

                    cNomTarjet = IIf(solicitud("cNombreTarjeta") = Nothing, "", solicitud("cNombreTarjeta").ToString.ToUpper)
                    nTarjeta = IIf(solicitud("cNumeroTarjeta") = Nothing, "", solicitud("cNumeroTarjeta").ToString.ToUpper)
                    cMes = IIf(solicitud("cMes") = Nothing, "", solicitud("cMes").ToString.ToUpper)
                    cAño = IIf(solicitud("cAno") = Nothing, "", solicitud("cAno").ToString.ToUpper)
                    cCodSeg = IIf(solicitud("cCodigoSeguridad") = Nothing, "", solicitud("cCodigoSeguridad").ToString.ToUpper)
                    'cBanco = IIf(solicitud("cBanco") = Nothing, "", solicitud("cBanco").ToString.ToUpper)
                    'cDireccionTH = IIf(solicitud("cDireccionTH") = Nothing, "", solicitud("cDireccionTH").ToString.ToUpper)
                    'cComprobante = IIf(solicitud("cComprobante") = Nothing, "", solicitud("cComprobante").ToString.ToUpper)
                    'cRFCDom = IIf(solicitud("cRFCDom") = Nothing, "", solicitud("cRFCDom").ToString.ToUpper)
                    'cFactura = IIf(solicitud("cFactura") = Nothing, "", solicitud("cFactura").ToString.ToUpper)

                    articulo140 = "<argumento id='2' tipo='' campo='' valor='" & correo.ToLower & "'/>"
                    articulo140 &= "<argumento id='3' tipo='' campo='' valor='" & cTelefono & "'/>"
                    articulo140 &= "<argumento id='4' tipo='' campo='' valor='" & cRFC & "'/>"

                    If tipopersona = "1" Then
                        articulo140 &= "<argumento id='6' tipo='' campo='' valor='" & cNacionalidad & "'/>"
                        articulo140 &= "<argumento id='7' tipo='' campo='' valor='" & nTipoIdentificacion & "'/>"
                        articulo140 &= "<argumento id='8' tipo='' campo='' valor='" & nIdentificacion & "'/>"
                        articulo140 &= "<argumento id='9' tipo='' campo='' valor='" & cOcupacion & "'/>"
                        articulo140 &= "<argumento id='18' tipo='' campo='' valor='" & cFiel & "'/>"
                        articulo140 &= "<argumento id='19' tipo='' campo='' valor='" & cFechaTH & "'/>"
                        articulo140 &= "<argumento id='20' tipo='' campo='' valor='" & cPais & "'/>"
                    Else
                        nombre = cRazon
                        articulo140 &= "<argumento id='10' tipo='' campo='' valor='" & nGiro & "'/>"
                        articulo140 &= "<argumento id='11' tipo='' campo='' valor='" & cAdministrador & "'/>"
                        articulo140 &= "<argumento id='12' tipo='' campo='' valor='" & cNacionalidadA & "'/>"
                        articulo140 &= "<argumento id='13' tipo='' campo='' valor='" & cRepresentante & "'/>"
                        articulo140 &= "<argumento id='14' tipo='' campo='' valor='" & cNacionalidadRepres & "'/>"
                    End If

                    If nTipoPago = 0 Then
                        complementoTarjetaCredito = " <tarjetacredito cliente='" & cNomTarjet & "' numero='" & nTarjeta & "' vencimiento='" & cMes & cAño & "' codigoseguridad='" & cCodSeg & "'/>"
                        complementoTarjetaCredito &= "<domiciliacion banco='" & cBanco & "' direcciontajetahabiente='" & cDireccionTH & "' envio='" & cComprobante & "' rfc='" & cRFCDom & "' fiscal='" & cFactura & "'/>"

                        If dtNegocio.Rows(0).Item("nCobroEnLinea") <> 10 Then
                            dtNegocio = FuncionesTransaccion.GetNegocio(dtNegocio.Rows(0).Item("nIdNegocioHijo"), DBError).Tables(0)
                        End If
                    End If

                    If solicitud("dInicio") = "" Then
                        dInicio = Date.Now
                    Else
                        dInicio = CDate(solicitud("dInicio"))
                    End If

                    If solicitud("dTermino") = "" Then
                        dTermino = Date.Now
                    Else
                        dTermino = CDate(solicitud("dTermino"))
                    End If
                End If

                Dim cMoneda As String = solicitud("cMoneda")
                strPaquete = "1" 'AMPLIA

                strCoberturas = " <cobertura id='02' desc='' sa='" & solicitud("cValorFactura").Replace(",", "") & "' tipo='2' ded='" & solicitud("nDD") & "' pma=''/>"
                strCoberturas &= "<cobertura id='04' desc='' sa='" & solicitud("cValorFactura").Replace(",", "") & "' tipo='2' ded='" & solicitud("nDR") & "' pma=''/>"

                Dim bSemiRemolque As Boolean = False
                Select Case cAMIS
                    Case "60000606", "60000607", "60000608"
                        bSemiRemolque = True
                    Case Else
                        strCoberturas &= "<cobertura id='06' desc='' sa='" & solicitud("cGM").Replace(",", "") & "' tipo='' ded='' pma=''/>"
                        strCoberturas &= "<cobertura id='07' desc='' sa='' tipo='' ded='' pma=''/>"
                        strCoberturas &= "<cobertura id='10' desc='' sa='' tipo='B' ded='' pma=''/>"
                        strCoberturas &= "<cobertura id='13' desc='' sa='" & (CDbl(solicitud("cMuerteAccidentalT")) / 50000) & "' tipo='' ded='' pma=''/>"

                        Dim Suma As Integer = CInt(solicitud("cRCLUC"))
                        Dim DeducibleUMA() As String = solicitud("cDeducibleRCLUC").Split(" ")

                        strCoberturas &= "<cobertura id='25' desc='' sa='" & (Suma / 2) & "' tipo='' ded='" & DeducibleUMA(0) & "' pma=''/>"
                        strCoberturas &= "<cobertura id='26' desc='' sa='" & (Suma / 2) & "' tipo='' ded='" & DeducibleUMA(0) & "' pma=''/>"

                        If solicitud("cRCCatastroficaT") <> "EXCLUIDA" Then
                            strCoberturas &= "<cobertura id='34' desc='' sa='" & solicitud("cRCCatastroficaT").Replace(",", "") & "' tipo='' ded='' pma=''/>"
                        End If

                        If solicitud("cGrua") <> "EXCLUIDA" And solicitud("cDeducibleGrua") <> "EXCLUIDA" Then
                            strCoberturas &= "<cobertura id='41' desc='' sa='" & solicitud("cGrua").Replace(",", "") & "' tipo='' ded='" & solicitud("cDeducibleGrua").Replace(",", "") & "' pma=''/>"
                        End If
                End Select

                If Not solicitud("cValorAdaptacion") = "" Then
                    If cTipo = "E" Then
                        Dim ArrAdaptaciones() As String = cAdaptaciones.Split("|")

                        For i As Integer = 0 To ArrAdaptaciones.Length - 1
                            Dim ArrAdaptacion() As String = ArrAdaptaciones(i).Split("-")

                            strCoberturas &= "<cobertura id='16' desc='" & ArrAdaptacion(1) & "' sa='" & ArrAdaptacion(0) & "' tipo='" & (i + 1) & "' ded='' pma=''/>"
                            strCoberturas &= "<cobertura id='17' desc='" & ArrAdaptacion(1) & "' sa='" & ArrAdaptacion(0) & "' tipo='" & (i + 1) & "' ded='' pma=''/>"
                        Next
                    Else
                        strCoberturas &= "<cobertura id='16' desc='ADAPTACION' sa='" & solicitud("cValorAdaptacion") & "' tipo='1' ded='' pma=''/>"
                        strCoberturas &= "<cobertura id='17' desc='ADAPTACION' sa='" & solicitud("cValorAdaptacion") & "' tipo='1' ded='' pma=''/>"
                    End If
                End If

                Dim strTipoPol As String = ""

                cFormaPago = solicitud("cFormaPago")
                Dim cMeses() As String = solicitud("cVigencia").Split(" ")
                Dim nMeses As Integer = cMeses(0)
                If cTipo = "C" Then
                    dTermino = dInicio.Date.AddMonths(nMeses)
                End If

                strTipoPol = "A"

                Dim ArrTipoCarga As String = solicitud("cDanosCarga")
                Dim cTipoCarga As String = ""
                Dim Descuento2 As String = solicitud("nDescuento")

                Select Case ArrTipoCarga
                    Case "EXCLUIDA"
                        cTipoCarga = ""
                    Case "CARGA A-No Peligrosa"
                        cTipoCarga = "A"
                    Case "CARGA B-Peligrosa"
                        cTipoCarga = "B"
                    Case "CARGA C-Alt Peligrosa"
                        cTipoCarga = "C"
                        Dim DeducibleUMA2() As String = solicitud("cDeducibleRCEco").Split(" ")
                        strCoberturas &= "<cobertura id='22' desc='' sa='" & solicitud("cRCEco").Replace(",", "") & "' tipo='' ded='" & DeducibleUMA2(0) & "' pma=''/>"
                End Select

                Dim nUso As Integer = 29
                Dim cUso As String = "CARGA"
                If solicitud("cDobleSemiremolque") = "AMPARADO" Then
                    nUso = 43
                    cUso = "DOBLE SEMIREMOLQUE"
                End If

                strXML = "<transacciones xmlns=''><transaccion version='1' tipotransaccion='" & cTipo & "' cotizacion='' negocio='{0}' tiponegocio=''><vehiculo id='1' amis='{1}' modelo='{2}' descripcion='" & solicitud("cDescripcion") & "' uso='" & nUso & "' servicio='9' plan='{3}' "
                strXML &= " motor='" & motor & "' serie='" & serie & "' repuve=' ' placas='" & placas & "' conductor='" & conductor & "' conductorliciencia='" & conductorliciencia & "' conductorfecnac='" & conductorfecnac & "' conductorocupacion='" & conductorocupacion & "' "
                strXML &= " estado='{4}' poblacion='POBLACION' color='" & nColor & "' dispositivo='' fecdispositivo='' tipocarga='" & cTipoCarga & "' tipocargadescripcion='" & solicitud("cDescripcionCarga") & "'>"
                strXML &= " {5}</vehiculo><asegurado id='' nombre='" & nombre & "' paterno='" & paterno & "' materno='" & materno & "' calle='" & calle & "' numerointerior='" & numerointerior & "' numeroexterior='" & numeroexterior & "' colonia='" & colonia & "' poblacion='" & poblacion & "' "
                strXML &= " estado='{4}' cp='" & cp & "' pais='" & pais & "' tipopersona='" & tipopersona & "'>" & articulo140 & "</asegurado>"

                strXML &= "<poliza id='' tipo='" & strTipoPol & "' endoso='' "
                strXML &= " fecemision='" & Format(Now.Date, "dd/MM/yyyy") & "' feciniciovig='{6}' fecterminovig='{7}' moneda='00' bonificacion='{8}' formapago='{9}' "
                strXML &= " agente='" & dtNegocio.Rows(0).Item("cUsuario") & "' tarifacuotas='1505' tarifavalores='1505' tarifaderechos='1505' beneficiario='" & cBeneficiario & "' politicacancelacion='1'>"

                If nIdNegocio <> 986 Then
                    strXML &= "<argumento id = '21' tipo='26' campo='26' valor='26'/>"
                End If
                If nMeses > 12 Then
                    strXML &= "<argumento id = '28' tipo='1' campo='1' valor='M'/>"
                Else
                    strXML &= "<argumento id = '28' tipo='1' campo='1' valor=''/>"
                End If

                strXML &= "<argumento id = '29' tipo='1' campo='1' valor='" & nMeses & "'/>"

                If (nRecargo = 1) Then
                    strXML &= "<argumento id='39B' tipo='1' campo='1' valor='1'/>"
                End If

                If bSemiRemolque Then
                    strXML &= "<argumento id='1002' tipo='1' campo='1' valor='1'/>"
                End If

                strXML &= "</poliza>"
                strXML &= "<prima primaneta='' derecho='' recargo='' impuesto='' primatotal='' comision=''/><recibo id='' feciniciovig='' fecterminovig='' primaneta='' derecho='' recargo='' impuesto='' primatotal='' comision='' cadenaoriginal='' sellodigital='' fecemision='' serie='' folio='' horaemision='' numeroaprobacion='' anoaprobacion='' numseriecertificado=''/><recibo id='' feciniciovig='' fecterminovig='' primaneta='' derecho='' recargo='' impuesto='' primatotal='' comision='' cadenaoriginal='' sellodigital='' fecemision='' serie='' folio='' horaemision='' numeroaprobacion='' anoaprobacion='' numseriecertificado=''/>" & complementoTarjetaCredito & "<error/></transaccion></transacciones>"
                strXML = String.Format(strXML, nIdNegocio, cAMIS, nModelo, strPaquete, cEstado, strCoberturas, Format(dInicio, "dd/MM/yyyy"), Format(dTermino, "dd/MM/yyyy"), Descuento2, cFormaPago)
                strXML = strXML.Replace("'", Chr(34))

                Dim strXmlSalida As String = strXML
                Dim xmlSalida As New XmlDocument

                xmlSalida.LoadXml(strXmlSalida)
                strXmlSalida = servicioANA.Transaccion(xmlSalida, wsANA.TipoTransaccion.Cotizacion, dtNegocio.Rows(0).Item("cUsuario"), dtNegocio.Rows(0).Item("cClave"))
                xmlSalida.LoadXml(strXmlSalida)

                If cTipo = "C" Then
                    Dim coberturas As String = ""
                    If xmlSalida.ChildNodes(1).ChildNodes(0).SelectSingleNode("//error").InnerText.Length > 0 Then
                        JsEval &= "Tractos.Mensaje('" & xmlSalida.ChildNodes(1).ChildNodes(0).SelectSingleNode("//error").InnerText & "', 100, 'auto'); "
                        cPrimaTotal = "Por el momento no podemos cotizar, intentelo más tarde."
                    Else
                        If xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText.ToString.Length > 0 Then

                            cPrimaTotal = xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText
                        End If

                        Dim intContadorCoberturas As Integer = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("//cobertura").Count
                        'xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Count        
                        coberturas = "<div class='tooltip2'> <span name='Coberturas' title='"
                        coberturas &= "&lt;table class=&quot;venSegTbl&quot;&gt;"
                        coberturas &= "&lt;tr height=&quot;30px&quot;&gt;"
                        coberturas &= "&lt;th&gt;Coberturas&lt;/th&gt;"
                        coberturas &= "&lt;th&gt;Suma Asegurada&lt;/th&gt;"
                        coberturas &= "&lt;th&gt;Deducible&lt;/th&gt;"
                        coberturas &= "&lt;/tr&gt;"
                        For z As Integer = 1 To intContadorCoberturas
                            coberturas &= "&lt;tr height=&quot;20px&quot;&gt;"
                            '//?xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(z - 1).InnerXml
                            '?xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(z - 1).SelectNodes("cobertura").Item(2).Attributes("")
                            coberturas &= "&lt;td&gt;" & xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).SelectNodes("cobertura").Item(z - 1).Attributes("desc").InnerText & "&lt;/td&gt;"
                            coberturas &= "&lt;td&gt;" & xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).SelectNodes("cobertura").Item(z - 1).Attributes("sa").InnerText & "&lt;/td&gt;"
                            If xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).SelectNodes("cobertura").Item(z - 1).Attributes("desc").InnerText = "RC ECOLOGICA" Then
                                coberturas &= "&lt;td&gt;" & solicitud("cDeducibleRCEco") & "&lt;/td&gt;"
                            Else
                                coberturas &= "&lt;td&gt;" & xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).SelectNodes("cobertura").Item(z - 1).Attributes("ded").InnerText & "&lt;/td&gt;"
                            End If

                            'coberturas &= xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).SelectNodes("cobertura").Item(z - 1).Attributes("pma").InnerText & "@"
                            coberturas &= "&lt;/tr&gt;"
                        Next

                        coberturas &= "&lt;/table&gt;'><img src='../Images/Text.png' style='width:16px;height:16px'/></span></div>"

                        Dim intContadorRecibos As Integer = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Count
                        nRecibos = intContadorRecibos

                        If intContadorRecibos.Equals(1) Then
                            cRecibo = cPrimaTotal
                        Else
                            For z As Integer = 1 To intContadorRecibos
                                Select Case z
                                    Case 1
                                        cRecibo = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Item(z - 1).Attributes("primatotal").InnerText
                                    Case 2
                                        cReciboSub = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Item(z - 1).Attributes("primatotal").InnerText
                                End Select
                            Next
                        End If

                        If cFormaPago <> "C" Then
                            cReciboSub = cRecibo
                        End If
                    End If

                    If IsNumeric(cPrimaTotal) Then
                        JsEval &= "$('#pnlPresentaCotizacion').show(); window.scrollTo(0,document.body.scrollHeight);"
                        JsEval &= "$('[name=Precio]').html('$ " & Format(CInt(cPrimaTotal), "##,#0.00") & "'); "
                        JsEval &= "$('[name=1erPago]').html('$ " & Format(CInt(cRecibo), "##,#0.00") & "'); "
                        JsEval &= "$('#Impresion').attr({ 'href': 'https://server.anaseguros.com.mx/anaweb/cotizacion.aspx?id=" & xmlSalida.ChildNodes(1).ChildNodes(0).Attributes("idCot").InnerText & "' }); "
                        'JsEval &= "$('#Impresion').attr({ 'href': 'http://localhost/anaweb/cotizacion.aspx?id=" & xmlSalida.ChildNodes(1).ChildNodes(0).Attributes("idCot").InnerText & "' }); "

                        Dim strSQL As String = "SELECT * FROM cotizacion WHERE cCotizacion = '" & xmlSalida.ChildNodes(1).ChildNodes(0).Attributes("idCot").InnerText & "'"
                        Dim ds As DataSet = FuncionesTransaccion.Query(strSQL, "")

                        Dim cDesglose As String = ds.Tables(0).Rows(0).Item("cDesglose").ToString.Replace("PARTICULAR", cUso)

                        If nMeses > 12 Then
                            cDesglose = cDesglose.Replace("||||", "|" & nMeses & " MESES||MULTIANUAL|")
                        End If

                        If ArrTipoCarga = "CARGA C-Alt Peligrosa" And Not solicitud("cDeducibleRCEco") = "0   UMA Diario" Then
                            cDesglose = cDesglose.Replace("<td class=Celda1>RC ECOLOGICA</td><td class=Celda2>" & solicitud("cRCEco") & ".00 POR EVENTO</td><td class=Celda3></td>", "<td class=Celda1>RC ECOLOGICA</td><td class=Celda2>" & solicitud("cRCEco") & ".00 POR EVENTO</td><td class=Celda3>" & solicitud("cDeducibleRCEco") & "</td>")
                        End If

                        strSQL = "UPDATE cotizacion SET cDesglose = '" & cDesglose & "' WHERE cCotizacion = '" & xmlSalida.ChildNodes(1).ChildNodes(0).Attributes("idCot").InnerText & "'"
                        FuncionesTransaccion.QueryE(strSQL, DBError)

                        JsEval &= "$('[name=Detalle]').html('" & coberturas.Replace("'", Chr(34)) & "'); "

                        'JsEval &= "$('#TxtVigencia').val('" & Format(dInicio, "dd/MM/yyyy") & "'); "
                        'JsEval &= "$('#TxtFinVigencia').val('" & Format(dTermino, "dd/MM/yyyy") & "'); "
                        JsEval &= "$('#TxtPrima').val('$ " & Format(CInt(cPrimaTotal), "##,#0.00") & "'); "
                        JsEval &= "$('#TxtPagoPrimer').val('$ " & Format(CInt(cRecibo), "##,#0.00") & "'); "

                        JsEval &= "$('[name=Coberturas]').tooltipster({contentAsHTML: true, interactive: true, position:'bottom', theme: 'tooltipster-shadow'});"
                        If Not cReciboSub = "" Then
                            JsEval &= "$('[name=SubSecuente]').html('$ " & Format(CInt(cReciboSub), "##,#0.00") & "'); "
                            JsEval &= "$('[name=tdSubSecuente]').show(); "
                            JsEval &= "$('[name=SubSecuente]').show(); "
                        Else
                            JsEval &= "$('[name=SubSecuente]').hide(); "
                            JsEval &= "$('[name=tdSubSecuente]').hide(); "
                        End If
                    Else
                        JsEval &= "$('[name=PrimaTotal]').html('" & cPrimaTotal & "'); "
                    End If
                    respuesta.Append(JsEval)
                Else
                    Dim strPoliza As String = ""
                    Dim strPrimaTotal As String = ""
                    Dim strLink As String = ""
                    Dim strComprobante As String = ""
                    Dim strXMLResultado As String = ""

                    If xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(2).Attributes("id").InnerText.ToString.Length > 0 Then
                        strPoliza = xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(2).Attributes("id").InnerText.ToString.Substring(2, 9)
                        strPrimaTotal = xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText
                        strXML = String.Format("<transacciones><transaccion version=""1"" tipotransaccion=""I""  negocio=""{1}""><poliza id=""{0}""  endoso=""000000"" inciso=""1"" link=""""></poliza><error/></transaccion></transacciones>", strPoliza, nIdNegocio)
                        Dim xmlImpresion As New XmlDocument
                        Dim xmlImpresionSalida As New XmlDocument
                        Dim strImpresionSalida As String = ""

                        xmlImpresion.LoadXml(strXML)
                        strImpresionSalida = servicioANA.Transaccion(xmlImpresion, wsANA.TipoTransaccion.Impresion, dtNegocio.Rows(0).Item("cUsuario"), dtNegocio.Rows(0).Item("cClave"))
                        'strImpresionSalida = x.Transaccion(xmlImpresion, servicioANA.Transaccion(xmlSalida, wsANA.TipoTransaccion.Impresion, "09048", "segonli9887"))
                        xmlImpresionSalida.LoadXml(strImpresionSalida)
                        strLink = xmlImpresionSalida.SelectSingleNode("//poliza").Attributes("link").InnerText
                        strComprobante = "https://server.anaseguros.com.mx/ananetws/comprobante.aspx?id=" & strPoliza

                        strXMLResultado = "$('#dvEmision').hide();$('#frmPoliza').show('drop'); $('#cmdPoliza2').attr('value','Póliza: " & strPoliza & "') ;"
                        strXMLResultado &= "$('#divTitulo').html('IMPRESION DE DOCUMENTOS'); $('html, body').animate({ scrollTop: 0 }, 'slow');"

                        strXMLResultado &= "$('#cmdPoliza').attr('href', '" & strLink & "');"
                        strXMLResultado &= "$('#cmbComprobante').attr('href', '" & strComprobante & "');"

                        Dim dtCliente As DataTable = FuncionesTransaccion.ConsultaRFC(cRFC, DBError)

                        If dtCliente.Rows.Count > 0 Then
                            FuncionesTransaccion.ModificaCliente(tipopersona, paterno, materno, nombre, cRazon, cFiel, dNacimiento, cPais, cEmail, cRFC, cCURP, cNacionalidad, nTipoIdentificacion, nIdentificacion, cOcupacion, calle, numeroexterior, numerointerior, cp, colonia, cTelefono, DBError)
                        Else
                            FuncionesTransaccion.InsertaCliente(tipopersona, paterno, materno, nombre, cRazon, cFiel, dNacimiento, cPais, cEmail, cRFC, cCURP, cNacionalidad, nTipoIdentificacion, nIdentificacion, cOcupacion, calle, numeroexterior, numerointerior, cp, colonia, cTelefono, DBError)
                        End If
                    Else
                        If xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(5).OuterXml = "<error>No se pudo realizar el cargo</error>" Then
                            strXMLResultado = "ASHT.MensajeSimple('No se pudo realizar el cargo a la tarjeta', '::ADVERTENCIA::', '', '300', '200');"
                        Else
101:                        strXMLResultado = "ASHT.MensajeSimple('" & xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(5).OuterXml & "',':: AVISO ::', '',300,'200');"
                        End If
                    End If

                    respuesta.Append(strXMLResultado)
                End If

            Case "ValorMaximoVehiculo"
                Dim cLlave As String = solicitud("cLlave")
                Dim cSubMarca() As String = solicitud("cSubmarca").Split(" ")
                Dim cAMIS As String = cSubMarca(0)
                Dim nIdNegocio As Integer = FuncionesTransaccion.GetIdNegocio(cLlave, DBError)
                Dim dtNegocio As DataTable = FuncionesTransaccion.GetNegocio(nIdNegocio, DBError).Tables(0)
                Dim JsEval As String = ""
                Dim ArrValoresMax() As String = dtNegocio.Rows(0).Item("cValorMaxT").ToString.Split("|")

                Select Case cAMIS
                    Case "40000404" 'RABON
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(0) & "'; "
                    Case "50000505" 'THORTON
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(1) & "'; "
                    Case "50000506" 'TRACTOCAMION
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(2) & "'; "
                    Case "50000507" 'TANDEM
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(3) & "'; "
                    Case "60000606" 'SEMIREMOLQUE IN
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(4) & "'; "
                    Case "60000607" 'DOLLY
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(5) & "'; "
                    Case "60000608" 'SEMIREMOLQUE
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(6) & "'; "
                    Case "11000103" 'CAMION 1.5
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(7) & "'; "
                    Case "20000204" 'CAMION 3.5
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(8) & "'; "
                    Case "30000302" 'CAMION 7.5
                        JsEval &= "Tractos.parametros.nValor = '" & ArrValoresMax(9) & "'; "
                End Select

                Select Case cAMIS
                    Case "60000606", "60000607", "60000608"
                        JsEval &= "$('#CmbRCLUC').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDeducibleRCLUC').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#cmbRCCatastroficaT').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDobleSemiremolque').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbMuerteAccidentalT').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbGM').attr('disabled', true).addClass('ui-state-disabled'); "
                    Case "11000103", "20000204"
                        JsEval &= "$('#CmbGrua').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDeducibleGrua').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                    Case Else
                        JsEval &= "$('#CmbRCLUC').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDeducibleRCLUC').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#cmbRCCatastroficaT').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDobleSemiremolque').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbMuerteAccidentalT').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbGM').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbGrua').attr('disabled', false).removeClass('ui-state-disabled'); "
                        JsEval &= "$('#CmbDeducibleGrua').attr('disabled', false).removeClass('ui-state-disabled'); "
                End Select

                'If nIdNegocio <> 986 Then
                'JsEval &= "$('#CmbGrua').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                'JsEval &= "$('#CmbDeducibleGrua').val('EXCLUIDA').attr('disabled', true).addClass('ui-state-disabled'); "
                'End If

                respuesta.Append(JsEval)
            Case "BuscarCliente"
                Dim cRFC As String = solicitud("cRFC")

                Dim dtCliente As DataTable = FuncionesTransaccion.ConsultaRFC(cRFC, DBError)

                If dtCliente.Rows.Count > 0 Then
                    With dtCliente.Rows(0)
                        jsCode = "$('#CmbTipoPersona').val('" & .Item("nTipoPersona") & "'); "
                        jsCode &= "$('#TxtPaterno').val('" & .Item("cPaterno") & "'); "
                        jsCode &= "$('#TxtMaterno').val('" & .Item("cMaterno") & "'); "
                        If dtCliente.Rows(0).Item("nTipoPersona") = 2 Then
                            jsCode &= "$('#TxtRazon').val('" & .Item("cNombre") & "'); "
                        Else
                            jsCode &= "$('#TxtNombre').val('" & .Item("cNombre") & "'); "
                        End If
                        jsCode &= "$('#TxtFIEL').val('" & .Item("cFIEL") & "'); "
                        jsCode &= "$('#TxtFecNaci').val('" & .Item("cNacimiento") & "'); "
                        jsCode &= "$('#TxtPais').val('" & .Item("cPais") & "'); "
                        jsCode &= "$('#TxtEmail').val('" & .Item("cCorreo") & "'); "
                        jsCode &= "$('#TxtTelefono').val('" & .Item("cTelefono") & "'); "
                        jsCode &= "$('#TxtRFC').val('" & .Item("cRFC") & "'); "
                        jsCode &= "$('#TxtCURP').val('" & .Item("cCURP") & "'); "
                        jsCode &= "$('#CmbNacionalidad').val('" & .Item("cNacionalidad") & "'); "
                        jsCode &= "$('#CmbIdentificacion').val('" & .Item("cIdentificacion") & "'); "
                        jsCode &= "$('#TxtNoIdentificacion').val('" & .Item("cNoIdentificacion") & "'); "
                        jsCode &= "$('#CmbOcupacion').val('" & .Item("cOcupacion") & "'); "
                        jsCode &= "$('#TxtCalle').val('" & .Item("cCalle") & "'); "
                        jsCode &= "$('#TxtNoExt').val('" & .Item("cExterior") & "'); "
                        jsCode &= "$('#TxtNoInt').val('" & .Item("cInterior") & "'); "
                        jsCode &= "$('#CmbCodigoPostal').val('" & .Item("cCP") & "').trigger('change'); "
                        jsCode &= "$('#CmbColonia').val('" & .Item("cColonia") & "'); "
                    End With
                Else
                    jsCode = "Tractos.Mensaje('Lo sentimos el cliente no existe, favor de verificar. gracias', 100, 100); "
                End If

                respuesta.Append(jsCode)
        End Select

    End Sub

    Protected Function MyFormatNumber(ByVal strValor As String) As String

        If strValor.Trim.Length.Equals(0) Then
            Return ""
        End If

        Dim iWhole As Long, iLen, sFraccion, iDecimalPoints
        Dim i As Long = 0
        Dim sResult

        'strValor = Math.Round(CDbl(strValor), 2).ToString
        If strValor.IndexOf(".") > 0 Then
            iWhole = strValor.Substring(0, strValor.IndexOf("."))
        Else
            iWhole = strValor
            strValor = strValor & ".00"
        End If

        'iWhole = 'Int(strValor)
        iLen = iWhole.ToString.Length
        iDecimalPoints = strValor.Length - iLen
        If iDecimalPoints > 0 Then sFraccion = Right(strValor, iDecimalPoints)
        For i = 1 To iLen
            sResult = Mid$(iWhole, iLen - i + 1, 1) & sResult
            If (i Mod 3 = 0) And (i <> iLen) Then sResult = "," & sResult
        Next

        If sFraccion.ToString.Length > 3 Then
            sFraccion = sFraccion.ToString.Substring(0, 3)
        End If

        Return sResult & sFraccion

    End Function

    Private Sub cargaNuevosCombos(ByVal Moneda As Long, ByVal dtNegocio As DataTable, ByRef JsEval As String)
        Dim strSQL As String = ""
        JsEval &= "$('#CmbRCEco').attr('disabled', true).addClass('ui-state-disabled'); "
        JsEval &= "$('#CmbDeducibleRCEco').attr('disabled', true).addClass('ui-state-disabled'); "

        Dim factor As Integer = 1
        If Moneda = 0 Then
            factor = 10
        End If

        Dim Inicio As Long = 0
        Dim Termino As Long = 0
        Dim Incremento As Long = 0

        If Moneda = 0 Then
            Inicio = 1000000
            Termino = 4000000
            Incremento = 50000
        Else
            Inicio = 100000
            Termino = 200000
            Incremento = 5000
        End If

        strSQL = ""
        Dim ArrRCLUC() As String = dtNegocio.Rows(0).Item("cRCLUC").ToString.Split("|")
        Dim RangoRCLUC() As String = ArrRCLUC(0).Split("-")

        For i As Long = RangoRCLUC(0) To RangoRCLUC(1) Step CInt(ArrRCLUC(1))
            strSQL &= "<option value='" & MyFormatNumber3(i * factor) & "'>" & MyFormatNumber3(i * factor) & "</option>"
        Next
        JsEval &= "$('#CmbRCLUC').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""

        Dim ArrDedRCLUC() As String = dtNegocio.Rows(0).Item("cDeducibleRCLUC").ToString.Split("|")
        For i As Long = 0 To ArrDedRCLUC.Length - 1
            strSQL &= "<option value='" & ArrDedRCLUC(i) & " UMA Diario" & "'>" & ArrDedRCLUC(i) & " UMA Diario" & "</option>"
        Next
        JsEval &= "$('#CmbDeducibleRCLUC').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= " <Option value='EXCLUIDA'>EXCLUIDA</option>"
        strSQL &= "<option value='CARGA A-No Peligrosa'>CARGA A-No Peligrosa</option>"
        strSQL &= "<option value='CARGA B-Peligrosa'>CARGA B-Peligrosa</option>"
        strSQL &= "<option value='CARGA C-Alt Peligrosa'>CARGA C-Alt Peligrosa</option>"
        JsEval &= "$('#CmbDanosCarga').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='EXCLUIDA'>EXCLUIDA</option>"
        strSQL &= "<option value='AMPARADO'>AMPARADO</option>"
        JsEval &= "$('#CmbDobleSemiremolque').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='-- SELECCIONAR --'>-- SELECCIONAR --</option>"

        Dim ArrRCEco() As String = dtNegocio.Rows(0).Item("cRCEcologica").ToString.Split("|")
        Dim RangoRCEco() As String = ArrRCEco(0).Split("-")

        For i As Long = RangoRCEco(0) To RangoRCEco(1) Step CInt(ArrRCEco(1))
            strSQL &= "<option value='" & MyFormatNumber3(i * factor) & "'>" & MyFormatNumber3(i * factor) & "</option>"
        Next
        JsEval &= "$('#CmbRCEco').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='0   UMA Diario'>0   UMA Diario</option>"

        Dim ArrDedRCEco() As String = dtNegocio.Rows(0).Item("cDeducibleRCEcologica").ToString.Split("|")

        For i As Long = 0 To ArrDedRCEco.Length - 1
            strSQL &= "<option value='" & ArrDedRCEco(i) & " UMA Diario" & "'>" & ArrDedRCEco(i) & " UMA Diario" & "</option>"
        Next

        JsEval &= "$('#CmbDeducibleRCEco').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        Dim ArrGM() As String = dtNegocio.Rows(0).Item("cGM").ToString.Split("|")
        Dim RangoGM() As String = ArrGM(0).Split("-")

        For i As Long = RangoGM(0) To RangoGM(1) Step CInt(ArrGM(1))
            strSQL &= "<option value='" & MyFormatNumber3(i * factor) & "'>" & MyFormatNumber3(i * factor) & "</option>"
        Next
        JsEval &= "$('#CmbGM').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        Dim ArrMuerteAccidental() As String = dtNegocio.Rows(0).Item("cMuerteAccidental").ToString.Split("|")
        Dim RangoMuerteAccidental() As String = ArrMuerteAccidental(0).Split("-")
        For i As Long = RangoMuerteAccidental(0) To RangoMuerteAccidental(1) Step CInt(ArrMuerteAccidental(1))
            strSQL &= "<option value='" & MyFormatNumber3(i * factor) & "'>" & MyFormatNumber3(i * factor) & "</option>"
        Next

        JsEval &= "$('#CmbMuerteAccidentalT').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='EXCLUIDA'>EXCLUIDA</option>"

        Dim ArrRCCatastrofica() As String = dtNegocio.Rows(0).Item("cRCCatastroficaT").ToString.Split("|")
        Dim RangoRCCatastrofica() As String = ArrRCCatastrofica(0).Split("-")
        For i As Long = RangoRCCatastrofica(0) To RangoRCCatastrofica(1) Step CInt(ArrRCCatastrofica(1))
            strSQL &= "<option value='" & MyFormatNumber3(i * factor) & "'>" & MyFormatNumber3(i * factor) & "</option>"
        Next
        JsEval &= "$('#cmbRCCatastroficaT').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='EXCLUIDA'>EXCLUIDA</option>"
        Dim ArrGrua() As String = dtNegocio.Rows(0).Item("cGrua").ToString.Split("|")
        For i As Long = 0 To ArrGrua.Length - 1
            strSQL &= "<option value='" & ArrGrua(i) & "'>" & ArrGrua(i) & " UMA Diario" & "</option>"
        Next
        JsEval &= "$('#CmbGrua').html('" & strSQL.Replace("'", Chr(34)) & "'); "

        strSQL = ""
        strSQL &= "<option value='EXCLUIDA'>EXCLUIDA</option>"
        Dim ArrDedGrua() As String = dtNegocio.Rows(0).Item("cDeducibleGrua").ToString.Split("|")
        For i As Long = 0 To ArrDedGrua.Length - 1
            strSQL &= "<option value='" & ArrDedGrua(i) & "'>" & ArrDedGrua(i) & " UMA Diario" & "</option>"
        Next
        JsEval &= "$('#CmbDeducibleGrua').html('" & strSQL.Replace("'", Chr(34)) & "'); "

    End Sub

    Protected Function MyFormatNumber3(ByVal strValor As String) As String

        If strValor.Trim.Length.Equals(0) Then
            Return ""
        End If

        Dim iWhole As Long, iLen, sFraccion, iDecimalPoints
        Dim i As Long = 0
        Dim sResult

        'strValor = Math.Round(CDbl(strValor), 2).ToString
        'If strValor.IndexOf(".") > 0 Then
        '    iWhole = strValor.Substring(0, strValor.IndexOf("."))
        'Else
        '    iWhole = strValor
        '    strValor = strValor & ".00"
        'End If

        iWhole = strValor

        'iWhole = 'Int(strValor)
        iLen = iWhole.ToString.Length
        'iDecimalPoints = strValor.Length - iLen
        'If iDecimalPoints > 0 Then sFraccion = Right(strValor, iDecimalPoints)
        For i = 1 To iLen
            sResult = Mid$(iWhole, iLen - i + 1, 1) & sResult
            If (i Mod 3 = 0) And (i <> iLen) Then sResult = "," & sResult
        Next

        'If sFraccion.ToString.Length > 3 Then
        'sFraccion = sFraccion.ToString.Substring(0, 3)
        'End If

        Return sResult '& sFraccion

    End Function

    Protected Sub CargaVigencia(ByRef JsEval As String, ByVal nTipoPoliza As Integer, ByVal nIdNegocio As Integer)
        Dim strSQL As String = "<option value='-- SELECCIONAR --'>-- SELECCIONAR --</option>"
        strSQL &= "<option value='12 MESES'>12 MESES</option>"
        Select Case nTipoPoliza
            Case 1, 0
                strSQL &= "<option value='24 MESES'>24 MESES</option>"
                strSQL &= "<option value='36 MESES'>36 MESES</option>"
                strSQL &= "<option value='48 MESES'>48 MESES</option>"
                strSQL &= "<option value='60 MESES'>60 MESES</option>"
                CargaFormaPago(JsEval, 9999)
            Case 2
                CargaFormaPago(JsEval, NidNegocio)
        End Select

        JsEval &= "$('#CmbVigencia2').html('" & strSQL.Replace("'", Chr(34)) & "'); "
    End Sub

    Protected Sub CargaFormaPago(ByRef JsEval As String, ByVal negocio As Long)
        Dim strError As String = ""
        Dim strSQL As String = ""
        Dim dsFormaPago As DataSet
        If negocio <> 9999 Then
            dsFormaPago = FuncionesTransaccion.GetFormaPago(negocio, strError)
        Else
            dsFormaPago = FuncionesTransaccion.GetFormaPago(9999, strError)
        End If

        For i As Integer = 0 To dsFormaPago.Tables(0).Rows.Count - 1
            strSQL &= "<option value='" & dsFormaPago.Tables(0).Rows(i).Item("cClaveFormapago") & "'>" & dsFormaPago.Tables(0).Rows(i).Item("cFormaPago") & "</option>"
        Next

        JsEval &= "$('#CmbFormaPago').html('" & strSQL.Replace("'", Chr(34)) & "'); "
    End Sub

    Protected Sub CargaModelo(ByVal VF As Integer, ByVal nIdNegocio As Integer, ByRef JsEval As String)
        Dim strError As String = ""
        Dim nModInf As Integer = FuncionesTransaccion.GetModelo(VF, nIdNegocio, strError)
        Dim strSQL As String = ""

        Dim incremento As Integer = IIf(Now.Month >= 8, 2, 1)
        'Dim decremento As Integer = IIf(Now.Month = 1, 1, 0)
        Dim ModeloSup As Long = Now.Year + incremento

        strSQL &= "<option value='0'>-- SELECCIONAR --</option>"
        For i As Integer = ModeloSup To nModInf Step -1
            strSQL &= "<option value='" & i & "'>" & i & "</option>"
        Next
        JsEval &= "$('#CmbModelo').html('" & strSQL.Replace("'", Chr(34)) & "'); "
    End Sub

    Protected Sub CargaMunicipio(ByVal nIdEstado As Integer, ByRef JsEval As String)
        Dim strError As String = ""
        Dim strSQL As String = ""
        Dim dsMunicipio As DataSet = FuncionesTransaccion.GetMunicipio(nIdEstado, strError)
        strSQL &= "<option value='0'>-- SELECCIONAR --</option>"
        For i As Integer = 0 To dsMunicipio.Tables(0).Rows.Count - 1
            strSQL &= "<option value='" & dsMunicipio.Tables(0).Rows(i).Item("nIdMunicipio") & "'>" & dsMunicipio.Tables(0).Rows(i).Item("cMunicipio") & "</option>"
        Next
        JsEval &= "$('#cmbMunicipio').html('" & strSQL.Replace("'", Chr(34)) & "'); "
    End Sub

    Protected Sub CargaCotizacion(ByVal tr As Object, ByVal lblEtiqueta As Label, ByVal lblPrima As Label, ByVal lblId As Object, ByVal nIdProducto As Long,
                                  ByVal strProducto As String, ByVal strClaveSISE As String, ByVal intCobertura As Integer, ByVal lblPrimerPago As Label,
                                  ByVal lblSubsecuente As Label, ByVal strValores As String, ByVal Vigencia As Integer, ByVal nIdNegocio As Integer,
                                  ByVal nModelo As String, ByVal cMarca As String, ByVal cSubMarca As String, ByVal cDescripcion As String,
                                  ByVal cDoblesemiremolque As String, ByVal cMotor As String, ByVal cSerie As String, ByVal cPlacas As String,
                                  ByVal cRepuve As String, ByVal nEstado As Integer, ByVal nMunicipio As String, ByVal cMunicipio As String,
                                  ByVal cDanosCarga As String, ByVal cDescripcionCarga As String, ByVal cBeneficiario As String, ByVal cValorFactura As String, ByVal cDD As String,
                                  ByVal cDR As String, ByVal cGastosMedicos As String, ByVal cMuerteAccidental As String, ByVal cValorAdaptacion As String,
                                  ByVal cRCLUC As String, ByVal cDeducibleRCLUC As String, ByVal cRCEcologica As String, ByVal cRCCatastrofica As String,
                                  ByVal cRCCatastroficaT As String, ByVal cGrua As String, ByVal cDeducibleGrua As String,
                                  ByVal cMoneda As String, ByVal cFormaPago As String, ByVal cTipoPoliza As String,
                                  ByVal cUsuarioSeg As String, ByVal cClaveSeg As String, Optional ByVal bEmite As Boolean = False)

        '        Dim bMultianualOtros As Boolean = False
        '        Dim bMotos As Boolean = False

        '        '0)Moneda 1)tarifa valores, 2)tarifa coutas, 3)tarifa derechos, 4)agente, 5)politica cancelacion, 6) Valor maximo de suma asegurada 7) llave negocio 8) negocio especial 9) valor factura
        '        Dim Valores() As String = strValores.Split("|")

        '        Dim strArreglo(200) As String
        '        Dim xmlSalida As New XmlDocument

        '        For i As Integer = 0 To 200
        '            strArreglo(i) = ""
        '        Next

        '        Dim dInicioVigencia As Date = Now
        '        Dim dTerminoVigencia As Date = Now

        '        dTerminoVigencia = Now.AddMonths(Vigencia)

        '        strArreglo(VERSION) = "1"
        '        strArreglo(TIPOTRANSACCION) = "C"
        '        strArreglo(COTIZACION) = ""
        '        strArreglo(NEGOCIO) = nIdNegocio

        '        strArreglo(VEHICULO_ID) = "1"

        '        strArreglo(VEHICULO_AMIS) = cSubMarca.Substring(0, 8)
        '        strArreglo(VEHICULO_MODELO) = nModelo
        '        strArreglo(VEHICULO_DESCRIPCION) = cMarca & "-" & cDescripcion

        '        If cDoblesemiremolque = "AMPARADO" Then
        '            strArreglo(VEHICULO_USO) = "43"
        '        Else
        '            strArreglo(VEHICULO_USO) = "29"
        '        End If

        '        strArreglo(VEHICULO_SERVICIO) = "9"
        '        strArreglo(VEHICULO_PLAN) = strClaveSISE
        '        strArreglo(VEHICULO_MOTOR) = cMotor.ToUpper   ' " " '"HECHO EN MEXICO"
        '        strArreglo(VEHICULO_SERIE) = cSerie.ToUpper   '" " '"ABCDEFGHIJK12333333"
        '        strArreglo(VEHICULO_REPUVE) = cRepuve.ToUpper   ' ""
        '        strArreglo(VEHICULO_PLACAS) = cPlacas.ToUpper '  ""
        '        strArreglo(VEHICULO_CONDUCTOR) = ""
        '        strArreglo(VEHICULO_CONDUCTOR_LICENCIA) = ""
        '        strArreglo(VEHICULO_CONDUCTOR_FECNAC) = ""
        '        strArreglo(VEHICULO_CONDUCTOR_OCUPACION) = ""
        '        strArreglo(VEHICULO_ESTADO) = Format(nEstado, "00") & Format(nMunicipio, "000")
        '        strArreglo(VEHICULO_POBLACION) = cMunicipio
        '        strArreglo(VEHICULO_COLOR) = "01"

        '        strArreglo(VEHICULO_TIPOCARGA_DESCRIPCION) = ""

        '        If cDanosCarga = "EXCLUIDA" Then
        '            strArreglo(VEHICULO_TIPOCARGA) = ""
        '        Else
        '            strArreglo(VEHICULO_TIPOCARGA) = cDanosCarga.Substring(6, 1)
        '            strArreglo(VEHICULO_TIPOCARGA_DESCRIPCION) = cDanosCarga
        '            strArreglo(VEHICULO_TIPOCARGA_DESCRIPCION) = cDescripcionCarga
        '        End If

        '        'COBERTURAS

        '        Dim Operacion As New ANANet.Transaccion
        '        Dim dsCoberturas As DataSet
        '        Dim strError As String = ""
        '        Dim strDeducibleDanos As String = ""
        '        Dim strDeducibleRobo As String = ""
        '        Dim strSumaAseguradaRCP As String = ""
        '        Dim strSumaAseguradaRCB As String = ""
        '        Dim strRCDeducible As String = ""
        '        Dim strSumaAseguradaGM As String = ""
        '        Dim bANARent As Boolean = False
        '        Dim strMuerteAccidental As String = ""
        '        Dim bExtencionCoberturas As Boolean = False
        '        Dim bRCUSA As Boolean = False

        '        Dim strSumaAseguradaRCO As String = ""
        '        Dim bAutoSustituto As Boolean = False
        '        Dim strTipoAsistencia As String = ""
        '        Dim strBeneficiarioMuerte As String = IIf(cBeneficiario > 0, cBeneficiario, "SUCESION LEGAL")

        '        strDeducibleDanos = cDD
        '        strDeducibleRobo = cDR
        '        strSumaAseguradaGM = cGastosMedicos.Replace(",", "")
        '        strMuerteAccidental = cMuerteAccidental

        '        If (cSubMarca.Substring(0, 8) = "60000606" Or cSubMarca.Substring(0, 8) = "60000607" Or cSubMarca.Substring(0, 8) = "60000608") Then

        '            strArreglo(VEHICULO_COBERTURA_ID) &= "02" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DESC) &= "" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_SA) &= cValorFactura & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_TIPO) &= "3" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DED) &= cDD & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_PMA) &= "" & strSeparador2Paso

        '            strArreglo(VEHICULO_COBERTURA_ID) &= "04" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DESC) &= "" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_SA) &= cValorFactura & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_TIPO) &= "3" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DED) &= cDR & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_PMA) &= "" & strSeparador2Paso

        '            If Val(cValorAdaptacion.Replace(",", "")) > 0 Then
        '                If bEmite Then
        '                    'For z As Long = 0 To lstCascoDetalle.Items.Count - 1
        '                    '    lstCascoDetalle.SelectedIndex = z
        '                    '    Dim SelecText As String = lstCascoDetalle()()
        '                    '    Dim TempText() As String = SelecText.Split(" -- ")
        '                    '    Dim textoAdaptacion As String = SelecText.Substring(SelecText.IndexOf(" -- ") + 4)

        '                    '    strArreglo(VEHICULO_COBERTURA_ID) &= "16" & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DESC) &= textoAdaptacion.Trim.ToUpper & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_SA) &= Val(TempText(0)).Replace(",", "") & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_TIPO) &= (z + 1) & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso

        '                    '    strArreglo(VEHICULO_COBERTURA_ID) &= "17" & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DESC) &= textoAdaptacion.Trim.ToUpper & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_SA) &= Val(TempText(0)).Replace(",", "") & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_TIPO) &= (z + 1) & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '                    'Next
        '                Else
        '                    strArreglo(VEHICULO_COBERTURA_ID) &= "16" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DESC) &= "ADAPTACION" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_SA) &= cValorAdaptacion.Replace(",", "") & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_TIPO) &= "1" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso

        '                    strArreglo(VEHICULO_COBERTURA_ID) &= "17" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DESC) &= "ADAPTACION" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_SA) &= cValorAdaptacion.Replace(",", "") & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_TIPO) &= "1" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '                End If
        '            End If
        '        Else
        '            dsCoberturas = Operacion.getCoberturasByProducto(nIdProducto, strError)

        '            For i As Integer = 0 To dsCoberturas.Tables(0).Rows.Count - 1
        '                With dsCoberturas.Tables(0).Rows(i)

        '                    Dim strDeducibleTemp As String = IIf(.IsNull("cDeducible"), "", .Item("cDeducible"))
        '                    Dim strSATemp As String = IIf(.IsNull("cSuma"), "", .Item("cSuma"))
        '                    'Dim strRCDedTemp As String = ""

        '                    Dim strTipoTemp As String = IIf(.IsNull("cTipo"), "", .Item("cTipo"))

        '                    If (.Item("cCobertura") = "18" And bANARent) Or (.Item("cCobertura") = "09" And bAutoSustituto) Or (.Item("cCobertura") = "13" And strMuerteAccidental.Length > 0) Or (.Item("cCobertura") = "12" And bExtencionCoberturas) Or (.Item("cCobertura") = "27" And bRCUSA) Or (.Item("cCobertura") = "10" And strTipoAsistencia.Length > 0) Then
        '                        GoTo Siguiente
        '                    Else
        '                        If .Item("cCobertura") = "09" And nModelo <= 1994 Then
        '                            GoTo Siguiente
        '                        End If
        '                    End If

        '                    If dsCoberturas.Tables(0).Rows(i).Item("cCobertura") = "03" And strDeducibleDanos.Length > 0 Then
        '                        strDeducibleTemp = strDeducibleDanos
        '                    End If

        '                    If .Item("cCobertura") = "02" And strDeducibleDanos.Length > 0 Then
        '                        strDeducibleTemp = strDeducibleDanos
        '                        strSATemp = cValorFactura
        '                    End If

        '                    If .Item("cCobertura") = "04" And strDeducibleRobo.Length > 0 Then
        '                        strDeducibleTemp = strDeducibleRobo
        '                        strSATemp = cValorFactura
        '                    End If

        '                    If .Item("cCobertura") = "06" Then
        '                        strSATemp = cGastosMedicos.Replace(",", "")
        '                    End If

        '                    If dsCoberturas.Tables(0).Rows(i).Item("cCobertura") = "25" Then
        '                        strSATemp = (cRCLUC.Replace(",", "")) / 2
        '                        strDeducibleTemp = Val(cDeducibleRCLUC)
        '                    End If

        '                    If dsCoberturas.Tables(0).Rows(i).Item("cCobertura") = "26" Then
        '                        strSATemp = (cRCLUC.Replace(",", "")) / 2
        '                        strDeducibleTemp = Val(cDeducibleRCLUC)
        '                    End If

        '                    If .Item("cCobertura") = "23" And strSumaAseguradaRCO.Length > 0 Then
        '                        strSATemp = strSumaAseguradaRCO
        '                    End If

        '                    If (nIdNegocio = "206" Or nIdNegocio = "208") And intCobertura = 2 Then

        '                    Else
        '                        If Val(Valores(9)) > 0 And chkVF.Checked AndAlso (.Item("cCobertura") = "02" Or .Item("cCobertura") = "03" Or .Item("cCobertura") = "04") Then
        '                            If strClaveSISE = "1" AndAlso strTipoTemp = "3" Then
        '                                strTipoTemp = "4"
        '                            End If
        '                            If nIdNegocio = "287" And strClaveSISE = "1" Then
        '                                strTipoTemp = "4"
        '                            End If
        '                        End If
        '                    End If

        '                    Dim strDescripcion As String = IIf(.IsNull("cDescripcion"), "", .Item("cDescripcion"))

        '                    strArreglo(VEHICULO_COBERTURA_ID) &= .Item("cCobertura") & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DESC) &= strDescripcion & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_SA) &= strSATemp & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_TIPO) &= strTipoTemp & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DED) &= strDeducibleTemp & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_PMA) &= .Item("cPrima") & strSeparador2Paso
        '                End With
        'Siguiente:
        '            Next

        '            'ESTO ESTA EN DURO PARA BAJACALIFORNIA Y NEGOCIO 133
        '            If nEstado = 2 And (strArreglo(NEGOCIO) = "133" Or strArreglo(NEGOCIO) = "136") Then
        '                strArreglo(VEHICULO_COBERTURA_SA) = strArreglo(VEHICULO_COBERTURA_SA).Replace("125000", "150000")
        '                If intCobertura = 1 Then
        '                    strProducto = "RC 300,000"
        '                Else
        '                    strProducto = "RC 300,000 + DJ"
        '                End If
        '            End If

        '            If strMuerteAccidental.Length > 0 Then
        '                strArreglo(VEHICULO_COBERTURA_ID) &= "13" & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DESC) &= strBeneficiarioMuerte.ToUpper & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_SA) &= strMuerteAccidental.ToUpper & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_TIPO) &= strMuerteAccidental.ToUpper & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DED) &= strMuerteAccidental.ToUpper & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '            End If

        '            If strTipoAsistencia.Length > 0 Then
        '                strArreglo(VEHICULO_COBERTURA_ID) &= "10" & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DESC) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_SA) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_TIPO) &= strTipoAsistencia & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '            End If

        '            If cRCEcologica <> "-- SELECCIONAR --" Then
        '                strArreglo(VEHICULO_COBERTURA_ID) &= "22" & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DESC) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_SA) &= cRCEcologica.Replace(",", "") & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_TIPO) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DED) &= Val(cmbDeducibleRCEco) & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '            End If

        '            If cRCCatastrofica <> "-- SELECCIONAR --" Then
        '                strArreglo(VEHICULO_COBERTURA_ID) &= "34" & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DESC) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_SA) &= cRCCatastrofica.Replace(",", "") & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_TIPO) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '            End If

        '            If Val(cValorAdaptacion.Replace(",", "")) > 0 Then
        '                If bEmite Then
        '                    'For z As Long = 0 To lstCascoDetalle.Items.Count - 1
        '                    '    lstCascoDetalle.SelectedIndex = z
        '                    '    Dim SelecText As String = lstCascoDetalle()()
        '                    '    Dim TempText() As String = SelecText.Split(" -- ")
        '                    '    Dim textoAdaptacion As String = SelecText.Substring(SelecText.IndexOf(" -- ") + 4)

        '                    '    strArreglo(VEHICULO_COBERTURA_ID) &= "16" & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DESC) &= textoAdaptacion.Trim.ToUpper & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_SA) &= Val(TempText(0)).Replace(",", "") & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_TIPO) &= (z + 1) & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso

        '                    '    strArreglo(VEHICULO_COBERTURA_ID) &= "17" & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DESC) &= textoAdaptacion.Trim.ToUpper & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_SA) &= Val(TempText(0)).Replace(",", "") & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_TIPO) &= (z + 1) & strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    '    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '                    'Next
        '                Else
        '                    strArreglo(VEHICULO_COBERTURA_ID) &= "16" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DESC) &= "ADAPTACION" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_SA) &= cValorAdaptacion.Replace(",", "") & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_TIPO) &= "1" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso

        '                    strArreglo(VEHICULO_COBERTURA_ID) &= "17" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DESC) &= "ADAPTACION" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_SA) &= cValorAdaptacion.Replace(",", "") & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_TIPO) &= "1" & strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                    strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '                End If
        '            End If


        '            strArreglo(VEHICULO_COBERTURA_ID) &= "13" & strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DESC) &= strSeparador2Paso
        '            'strArreglo(VEHICULO_COBERTURA_SA) &= cMuerteAccidentalT.SelectedIndex + 1 & strSeparador2Paso ' ||||||||||PREGUNTAR!!!!!||||||||||
        '            strArreglo(VEHICULO_COBERTURA_TIPO) &= strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '            strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso

        '            If cRCCatastroficaT <> "-- SELECCIONAR --" Then
        '                'If cmbSubMarca.Substring(0, 8) <> "60000606" And cmbSubMarca.Substring(0, 8) <> "60000607" Then
        '                strArreglo(VEHICULO_COBERTURA_ID) &= "34" & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DESC) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_SA) &= cRCCatastroficaT.Replace(",", "") & strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_TIPO) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_DED) &= strSeparador2Paso
        '                strArreglo(VEHICULO_COBERTURA_PMA) &= strSeparador2Paso
        '                'End If
        '            End If

        '        End If

        '        strArreglo(ASEGURADO_ESTADO) = Format(Val(cEstado), "00") & Format(Val(cMunicipio), "000")

        '        If Vigencia = 24 Then
        '            strArreglo(POLIZA_TIPO) = "C"
        '        Else
        '            strArreglo(POLIZA_TIPO) = "A"
        '        End If

        '        If bMultianualOtros Then
        '            strArreglo(85) &= "25" & strSeparador1Paso
        '            strArreglo(86) &= "" & strSeparador1Paso
        '            strArreglo(87) &= "" & strSeparador1Paso
        '            strArreglo(88) &= "" & strSeparador1Paso
        '            strArreglo(85) &= "34" & strSeparador1Paso
        '            strArreglo(86) &= "" & strSeparador1Paso
        '            strArreglo(87) &= "" & strSeparador1Paso
        '            strArreglo(88) &= "" & strSeparador1Paso
        '        End If

        '        'If lblDesRec = "1" Then
        '        '    strArreglo(85) &= "39" & strSeparador1Paso
        '        '    strArreglo(86) &= "" & strSeparador1Paso
        '        '    strArreglo(87) &= "" & strSeparador1Paso
        '        '    strArreglo(88) &= "" & strSeparador1Paso
        '        'End If

        '        ' If (strArreglo(NEGOCIO) = "320" Or strArreglo(NEGOCIO) = "440" Or strArreglo(NEGOCIO) = "463" Or strArreglo(NEGOCIO) = "457") Then

        '        'If lblFinVigencia = "1" Then
        '        '    strArreglo(POLIZA_FECEMISION) = Format(Now, "dd/MM/yyyy")
        '        '    strArreglo(POLIZA_FECINICIOVIG) = txtFechaInicioVig 'txtInicioVigencia
        '        '    strArreglo(POLIZA_FECTERMINOVIG) = lblFechaFinVig.InnerHtml()   ' txtTerminoVigencia
        '        '    strArreglo(85) &= "25" & strSeparador1Paso
        '        '    strArreglo(86) &= "" & strSeparador1Paso
        '        '    strArreglo(87) &= "" & strSeparador1Paso
        '        '    strArreglo(88) &= "" & strSeparador1Paso
        '        '    strArreglo(85) &= "34" & strSeparador1Paso
        '        '    strArreglo(86) &= "" & strSeparador1Paso
        '        '    strArreglo(87) &= "" & strSeparador1Paso
        '        '    strArreglo(88) &= "" & strSeparador1Paso
        '        'Else
        '        strArreglo(POLIZA_FECEMISION) = Format(Now, "dd/MM/yyyy")
        '        strArreglo(POLIZA_FECINICIOVIG) = Format(dInicioVigencia, "dd/MM/yyyy") 'txtInicioVigencia
        '        strArreglo(POLIZA_FECTERMINOVIG) = Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        'End If


        '        strArreglo(POLIZA_MONEDA) = cMoneda

        '        'If lblDescuentoVisible = "1" Then
        '        '    strArreglo(POLIZA_BONIFICACION) = cmbDescuento
        '        'Else
        '        '    If cmbVigencia = "2" Then
        '        '        strArreglo(POLIZA_BONIFICACION) = lblDescuento2
        '        '    Else
        '        '        strArreglo(POLIZA_BONIFICACION) = lblDescuento
        '        '    End If
        '        'End If

        '        'If cmbArmadora = "XS" Then
        '        'strArreglo(POLIZA_BONIFICACION) = "0"
        '        'End If

        '        strArreglo(POLIZA_FORMAPAGO) = cFormaPago
        '        strArreglo(POLIZA_AGENTE) = Valores(4)

        '        strArreglo(POLIZA_TARIFACUOTA) = Valores(1)
        '        strArreglo(POLIZA_TARIFAVALORES) = Valores(2)
        '        strArreglo(POLIZA_TARIFADERECHOS) = Valores(3)
        '        strArreglo(POLIZA_BENEFICIARIO) = ""
        '        strArreglo(POLIZA_POLITICACANCCELACION) = Valores(5)

        '        If Val(Valores(8)) > 0 Then
        '            strArreglo(85) &= "21" & strSeparador1Paso
        '            strArreglo(86) &= "" & strSeparador1Paso
        '            strArreglo(87) &= "" & strSeparador1Paso
        '            strArreglo(88) &= Long.Parse(Valores(8)).ToString("00") & strSeparador1Paso
        '        End If

        '        If Val(Valores(13)) > 0 Then
        '            strArreglo(85) &= "24" & strSeparador1Paso
        '            strArreglo(86) &= "" & strSeparador1Paso
        '            strArreglo(87) &= "" & strSeparador1Paso
        '            ' strArreglo(88) &= txtDatoAdicional & strSeparador1Paso ||||||PREGUNTAR||||||||
        '        End If

        '        Dim dsCondicionesadicionales As DataSet = Operacion.getCondcionesAdicionalesByProducto(nIdProducto, strError)

        '        For i As Long = 0 To dsCondicionesadicionales.Tables(0).Rows.Count - 1
        '            If dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") = "23" Then
        '                'If cmbTipoVehiculo = 210 Or cmbTipoVehiculo = 220 Or cmbTipoVehiculo = 230 Then
        '                '    strArreglo(85) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") & strSeparador1Paso
        '                '    strArreglo(86) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                '    strArreglo(87) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                '    strArreglo(88) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                'End If
        '            Else
        '                If dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") = "21" And nEstado = 2 And (strArreglo(NEGOCIO) = "133" Or strArreglo(NEGOCIO) = "136") Then
        '                    strArreglo(85) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") & strSeparador1Paso
        '                    strArreglo(86) &= "17" & strSeparador1Paso
        '                    strArreglo(87) &= "17" & strSeparador1Paso
        '                    strArreglo(88) &= "17" & strSeparador1Paso
        '                Else
        '                    If dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") = "28" And lblTractos = "1" Then
        '                        strArreglo(85) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") & strSeparador1Paso
        '                        strArreglo(86) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                        strArreglo(87) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                        Select Case cTipoPoliza
        '                            Case 2
        '                                strArreglo(88) &= "" & strSeparador1Paso
        '                            Case 0
        '                                strArreglo(88) &= "M" & strSeparador1Paso
        '                            Case 1
        '                                strArreglo(88) &= "P" & strSeparador1Paso
        '                        End Select
        '                    Else
        '                        If dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") = "29" And lblTractos = "1" Then
        '                            strArreglo(85) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") & strSeparador1Paso
        '                            strArreglo(86) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                            strArreglo(87) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                            strArreglo(88) &= Val(cmbVigencia2) & strSeparador1Paso
        '                        Else
        '                            strArreglo(85) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cArgumento") & strSeparador1Paso
        '                            strArreglo(86) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                            strArreglo(87) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                            strArreglo(88) &= dsCondicionesadicionales.Tables(0).Rows(i).Item("cValor") & strSeparador1Paso
        '                        End If
        '                    End If
        '                End If
        '            End If

        '        Next

        '        'If lblMultianual = "1" Then
        '        strArreglo(85) &= "33" & strSeparador1Paso
        '        strArreglo(86) &= "" & strSeparador1Paso
        '        strArreglo(87) &= "" & strSeparador1Paso
        '        strArreglo(88) &= "" & strSeparador1Paso
        '        'End If
        '        strArreglo(VEHICULO_DISPOSITIVO) = ""
        '        strArreglo(VEHICULO_FECDISPOSITIVO) = ""

        '        '        If bEmite Then
        '        '            If lblSoloSegullantas = "1" Then
        '        '                strArreglo(85) &= "35" & strSeparador1Paso
        '        '                strArreglo(86) &= "1" & strSeparador1Paso
        '        '                strArreglo(87) &= "" & strSeparador1Paso
        '        '                strArreglo(88) &= txtSerie1 & strSeparador1Paso

        '        '                strArreglo(85) &= "35" & strSeparador1Paso
        '        '                strArreglo(86) &= "2" & strSeparador1Paso
        '        '                strArreglo(87) &= "" & strSeparador1Paso
        '        '                strArreglo(88) &= txtSerie2 & strSeparador1Paso

        '        '                strArreglo(85) &= "35" & strSeparador1Paso
        '        '                strArreglo(86) &= "3" & strSeparador1Paso
        '        '                strArreglo(87) &= "" & strSeparador1Paso
        '        '                strArreglo(88) &= txtSerie3 & strSeparador1Paso

        '        '                strArreglo(85) &= "35" & strSeparador1Paso
        '        '                strArreglo(86) &= "4" & strSeparador1Paso
        '        '                strArreglo(87) &= "" & strSeparador1Paso
        '        '                strArreglo(88) &= txtSerie4 & strSeparador1Paso
        '        '            End If

        '        '            If txtBeneficiarioPreferente.Trim.Length > 0 Then
        '        '                strArreglo(POLIZA_BENEFICIARIO) = txtBeneficiarioPreferente
        '        '            End If

        '        '            If cmbBeneficiarioPreferente.SelectedIndex > 0 Then
        '        '                strArreglo(POLIZA_BENEFICIARIO) = cmbBeneficiarioPreferente
        '        '            End If

        '        '            strArreglo(VEHICULO_MOTOR) = txtMotor.ToUpper
        '        '            strArreglo(VEHICULO_SERIE) = txtSerie.ToUpper
        '        '            strArreglo(VEHICULO_PLACAS) = txtPlacas.ToUpper
        '        '            strArreglo(VEHICULO_REPUVE) = txtRepuve.ToUpper
        '        '            If cmbColor = 100 Then
        '        '                strArreglo(VEHICULO_COLOR) = "00"
        '        '            Else
        '        '                strArreglo(VEHICULO_COLOR) = cmbColor.ToUpper
        '        '            End If
        '        '            strArreglo(VEHICULO_CONDUCTOR) = txtConductor.ToUpper
        '        '            strArreglo(VEHICULO_CONDUCTOR_LICENCIA) = txtLicenciaConductor.ToUpper
        '        '            strArreglo(VEHICULO_CONDUCTOR_FECNAC) = txtNacimientoConductor
        '        '            strArreglo(VEHICULO_CONDUCTOR_OCUPACION) = ""

        '        '            strArreglo(ASEGURADO_ARGUMENTO_ID) = "2" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_TIPO) = "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_CAMPO) = "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_VALOR) = txtEmail & strSeparador1Paso

        '        '            strArreglo(ASEGURADO_ARGUMENTO_ID) &= "3" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtTelefono.ToUpper & strSeparador1Paso

        '        '            strArreglo(ASEGURADO_ARGUMENTO_ID) &= "4" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '            strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtRFC.ToUpper & strSeparador1Paso

        '        '            If cmbTipoPersona.Equals("1") Then
        '        '                strArreglo(ASEGURADO_NOMBRE) = txtNombre.ToUpper
        '        '                strArreglo(ASEGURADO_PATERNO) = txtPaterno.ToUpper
        '        '                strArreglo(ASEGURADO_MATERNO) = txtMaterno.ToUpper

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "5" & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtCURP.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "6" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbNacionalidad.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "7" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbIdentificacion.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "8" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtNoIdentificacion.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "9" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbOcupacion.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "18" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtFIEL.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "19" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtFecNaci.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "20" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtPais.ToUpper & strSeparador1Paso

        '        '            Else
        '        '                strArreglo(ASEGURADO_NOMBRE) = txtPaterno
        '        '                strArreglo(ASEGURADO_PATERNO) = ""
        '        '                strArreglo(ASEGURADO_MATERNO) = ""

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "10" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbGiro.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "11" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtAministrador.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "12" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbNacionalidadA.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "13" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= "" & strSeparador1Paso
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= txtRepresentante.ToUpper & strSeparador1Paso

        '        '                strArreglo(ASEGURADO_ARGUMENTO_ID) &= "14"
        '        '                strArreglo(ASEGURADO_ARGUMENTO_TIPO) &= ""
        '        '                strArreglo(ASEGURADO_ARGUMENTO_CAMPO) &= ""
        '        '                strArreglo(ASEGURADO_ARGUMENTO_VALOR) &= cmbNacionalidadR.ToUpper & strSeparador1Paso
        '        '            End If

        '        '            If bEmite And txtUsuario.Trim.Length > 0 Then
        '        '                strArreglo(85) &= "20"
        '        '                strArreglo(86) &= ""
        '        '                strArreglo(87) &= ""
        '        '                strArreglo(88) &= "www" & Operacion.Contador() & txtUsuario
        '        '            End If

        '        '            strArreglo(ASEGURADO_CALLE) = txtCalle.ToUpper
        '        '            strArreglo(ASEGURADO_NUMEROINTERIOR) = txtNoInt.ToUpper
        '        '            strArreglo(ASEGURADO_NUMEROEXTERIOR) = txtNoExt.ToUpper
        '        '            strArreglo(ASEGURADO_COLONIA) = cmbColonia.ToUpper
        '        '            strArreglo(ASEGURADO_POBLACION) = cMunicipio.ToUpper
        '        '            strArreglo(ASEGURADO_CODIGOPOSTAL) = cmbCodigoPostal.ToUpper     '"" 'txtCP
        '        '            strArreglo(ASEGURADO_PAIS) = "MEXICO"
        '        '            strArreglo(ASEGURADO_TIPOPERSONA) = cmbTipoPersona.ToUpper

        '        '            strArreglo(TIPOTRANSACCION) = "E"

        '        '            strArreglo(POLIZA_FECEMISION) = Format(Now, "dd/MM/yyyy")
        '        '            'txtVigencia

        '        '            If lblFinVigencia = "1" Then
        '        '                strArreglo(POLIZA_FECINICIOVIG) = txtFechaInicioVig 'txtInicioVigencia
        '        '                strArreglo(POLIZA_FECTERMINOVIG) = lblFechaFinVig.InnerHtml()   ' txtTerminoVigencia
        '        '                strArreglo(85) &= "25" & strSeparador1Paso
        '        '                strArreglo(86) &= "" & strSeparador1Paso
        '        '                strArreglo(87) &= "" & strSeparador1Paso
        '        '            Else
        '        '                strArreglo(POLIZA_FECINICIOVIG) = Format(CDate(txtVigencia), "dd/MM/yyyy") 'Format(dInicioVigencia, "dd/MM/yyyy") 'txtInicioVigencia
        '        '                If lblSeguroXDias = "1" Then
        '        '                    strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddDays(cmbDias), "dd/MM/yyyy")
        '        '                Else
        '        '                    If lblTractos = "0" Then
        '        '                        Select Case cmbVigencia
        '        '                            Case 1
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddYears(1), "dd/MM/yyyy")  'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            'dTerminoVigencia = Now.AddYears(1)
        '        '                            Case 2
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(1), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            'dTerminoVigencia = Now.AddMonths(1)
        '        '                            Case 3 '6 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(6), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            'dTerminoVigencia = Now.AddMonths(6)
        '        '                            Case 4 '18 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(18), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            'dTerminoVigencia = Now.AddMonths(18)
        '        '                            Case 5 '24 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(24), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            'dTerminoVigencia = Now.AddMonths(24)
        '        '                            Case 36 '36 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(36), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            Case 37 '48 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(48), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                            Case 38 '60 meses
        '        '                                strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(60), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                        End Select


        '        '                        'If strArreglo(POLIZA_TIPO).Equals("A") Then
        '        '                        '    strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddYears(1), "dd/MM/yyyy")  'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                        'Else
        '        '                        '    strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(1), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '                        'End If
        '        '                    Else
        '        '                        strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtVigencia).AddMonths(Val(cmbVigencia2)), "dd/MM/yyyy")
        '        '                    End If
        '        '                End If
        '        '            End If
        '        '            'strArreglo(POLIZA_FECINICIOVIG) = Format(CDate(txtFecha1), "dd/MM/yyyy") 'Format(dInicioVigencia, "dd/MM/yyyy") 'txtInicioVigencia
        '        '            'If strArreglo(POLIZA_TIPO).Equals("A") Then
        '        '            '    strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtFecha1).AddYears(1), "dd/MM/yyyy")  'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '            'Else
        '        '            '    strArreglo(POLIZA_FECTERMINOVIG) = Format(CDate(txtFecha1).AddMonths(1), "dd/MM/yyyy")   'Format(dTerminoVigencia, "dd/MM/yyyy") ' txtTerminoVigencia
        '        '            'End If

        '        '            Dim strPolizaLlave As String = ""
        '        '            Dim strReferencia As String = ""
        '        '            Dim strCadena As String = ""

        '        '            strPolizaLlave = Operacion.AutoId(20)
        '        '            For i As Integer = 0 To 200
        '        '                strCadena &= strArreglo(i) & "¬"
        '        '            Next
        '        '            If lblCotizacion <> "0" Then
        '        '                Operacion.actualizaCotSerie(lblCotizacion, txtSerie, "", "2")
        '        '            End If

        '        '            Dim ValoresTemp() As String = lblValores.Split("|")
        '        '            If lblTipoCobranza = "3" Or lblTipoCobranza = "4" Then
        '        '                If cmbFormaAdquisicion.SelectedIndex = 1 Then
        '        '                    'pago referenciado
        '        '                    GoTo 20
        '        '                Else
        '        '                    'tc
        '        '                    GoTo 10
        '        '                End If
        '        '            End If

        '        '            If lblTipoCobranza <> "0" Then
        '        '10:             strReferencia = Operacion.GetReferencia(strPolizaLlave, strError)
        '        '                For I As Long = 1 To 14 - strReferencia.Length
        '        '                    strReferencia = "0" & strReferencia
        '        '                Next
        '        '                strReferencia = strReferencia & "-" & (DateDiff(DateInterval.Day, CDate("01/01/1968"), CDate(strArreglo(POLIZA_FECINICIOVIG)))) + 1
        '        '                Dim strReferenciaCompleta As String = ""
        '        '                If lblTipoCobranza.Equals("1") Or lblTipoCobranza.Equals("3") Then
        '        '                    strReferenciaCompleta = strReferencia & "|" & "90000000000000000001" & "|293|" & lblPrimerPago.Replace("$", "").Replace(",", "") & "|" & Trim$(txtNombre.ToUpper & " " & txtPaterno.ToUpper & " " & txtMaterno.ToUpper) & "|1|1|" & txtTelefono & "|" & txtEmail & "|" & IIf(strArreglo(POLIZA_TIPO) = "C", "S", "N")
        '        '                Else
        '        '                    strReferenciaCompleta = strReferencia & "|" & "90000000000000000001" & "|293|1.00|" & Trim$(txtNombre.ToUpper & " " & txtPaterno.ToUpper & " " & txtMaterno.ToUpper) & "|1|1|" & txtTelefono & "|" & txtEmail & "|" & IIf(strArreglo(POLIZA_TIPO) = "C", "S", "N")
        '        '                End If

        '        '                If Operacion.GuardaPreCobro(strReferencia, strPolizaLlave, lblIdNegocio, strCadena, txtSerie, strReferenciaCompleta, strError, lblTractos) Then
        '        '                    Response.Redirect("https://server.anaseguros.com.mx/anaweb/continua.aspx?idN=" & ValoresTemp(7) & "&IdTran=" & strPolizaLlave.Substring(0, 3) & "1" & strPolizaLlave.Substring(3))
        '        '                Else
        '        '                    MensajeError(strError)
        '        '                    Exit Sub
        '        '                End If
        '        '            Else
        '        '20:             If Operacion.GuardaPreEmision(strPolizaLlave, lblIdNegocio, strCadena, txtSerie, strError, lblTractos) Then                    'Session("TipoProceso") = "0"
        '        '                    Response.Redirect("http://server.anaseguros.com.mx/anaweb/continua.aspx?idN=" & ValoresTemp(7) & "&IdTran=" & strPolizaLlave.Substring(0, 3) & "0" & strPolizaLlave.Substring(3))
        '        '                    'Response.Redirect("https://server.anaseguros.com.mx/anaweb/continua.aspx?idN=" & ValoresTemp(7) & "&IdTran=" & strPolizaLlave.Substring(0, 3) & "0" & strPolizaLlave.Substring(3))
        '        '                Else
        '        '                    MensajeError(strError)
        '        '                    Exit Sub
        '        '                End If
        '        '            End If

        '        '        End If

        '        Dim strXmlSalida As String = Funciones.ARR2XML(strArreglo)

        '        If strXmlSalida.Length > 0 Then
        '            strXmlSalida = "<?xml version=""1.0"" encoding=""UTF-8"" ?><transacciones>" & strXmlSalida & "</transacciones>"
        '            'strXmlSalida = strXmlSalida.Replace("<", "").Replace(">", "")
        '            xmlSalida.LoadXml(strXmlSalida)
        '            Dim wsTransaccion As New wsANA.Service
        '            Try
        '                strXmlSalida = wsTransaccion.Transaccion(xmlSalida, wsANA.TipoTransaccion.Cotizacion, cUsuarioSeg, cClaveSeg)
        '                xmlSalida.LoadXml(strXmlSalida)
        '            Catch ex As Exception
        '                'MensajeError("No pude cotizar favor de volverlo a intentar en un momento mas")
        '                'OcultaCotizacion()
        '                Exit Sub
        '            End Try

        '            If Val(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primaneta").InnerText) > 0 Then
        '                Dim factor As Integer = 1
        '                Dim PrimaSinFactor As String = ""
        '                If cTipoPoliza = 0 Then
        '                    factor = Val(Vigencia) / 12
        '                End If
        '                tr.visible = True
        '                'lblEtiqueta = strProducto
        '                Dim separadorDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        '                If separadorDecimal = "," Then
        '                    lblPrima.Text = " $ " & MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText.Replace(",", "").Replace(".", ",") * factor).ToString.Replace(",", "."))
        '                Else
        '                    lblPrima.Text = " $ " & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText * factor)
        '                End If

        '                PrimaSinFactor = " $ " & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText)
        '                Dim dblPrimaTotalQ As String = xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText

        '                If xmlSalida.ChildNodes(1).ChildNodes(0).SelectSingleNode("//error").InnerText.Length > 0 Then
        '                    'MensajeError(xmlSalida.ChildNodes(1).ChildNodes(0).SelectSingleNode("//error").InnerText)
        '                    'If xmlSalida.ChildNodes(1).ChildNodes(0).SelectSingleNode("//error").InnerText.Substring(0, 3).Equals("500") Then
        '                    'cmbSiguiente.Enabled = False
        '                    'Else
        '                    'cmbSiguiente.Enabled = True
        '                    'End If
        '                Else
        '                    'cmbSiguiente.Enabled = True
        '                End If

        '                Dim intContadorRec As Integer = 0
        '                'Dim xnlnRecibos As XmlNode
        '                Dim intContadorRecibos As Integer = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Count

        '                lblPrimerPago.Text = ""
        '                lblSubsecuente.Text = ""
        '                'lblEtiquetaSubsecuente.Visible = False

        '                If intContadorRecibos.Equals(1) Then
        '                    lblPrimerPago.Text = PrimaSinFactor

        '                    If Val(Valores(10)) = 1 Then
        '                        lblPrimerPago = " $ " & MyFormatNumber2(dblPrimaTotalQ, Val(Valores(12)))
        '                        lblEtiqueta1er.InnerHtml = "&nbsp;<strong>Pagos (" & Valores(12) & ")</strong>&nbsp;"
        '                        lblPagos = "Pagos (" & Valores(12) & ")"
        '                    Else
        '                        lblEtiqueta1er.InnerHtml = "&nbsp;<strong>1er. Pago</strong>&nbsp;"
        '                    End If
        '                Else
        '                    For z As Integer = 1 To intContadorRecibos
        '                        Select Case z
        '                            Case 1
        '                                lblPrimerPago.Text = " $ " & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Item(z - 1).Attributes("primatotal").InnerText)
        '                                lblPrimerPago.Visible = True
        '                            Case 2
        '                                lblSubsecuente.Text = " $ " & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("recibo").Item(z - 1).Attributes("primatotal").InnerText)
        '                                lblSubsecuente.Visible = True
        '                                lblEtiquetaSubsecuente.Visible = True
        '                                lblEtiquetaSubsecuente = "Subsecuente (" & (intContadorRecibos - 1) & ")"
        '                        End Select
        '                    Next
        '                End If

        '                Dim intContadorCober As Integer = 0
        '                Dim xnlnCoberturas As XmlNode
        '                Dim intContadorCoberturas As Integer = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).ChildNodes.Count

        '                Dim strDesgloceCoberturasTemp As String = ""
        '                Dim strDesgloceCoberturas As String = "<table style=width:100%><tr><td align=right><input id=Button1 type=button value=X onclick=OcultaCoberturas()></td></tr></table>"
        '                strDesgloceCoberturas &= "<table border=0 cellspacing=0 cellpadding=0 width=418>"

        '                strDesgloceCoberturas &= "<tr>"
        '                strDesgloceCoberturas &= "    <td class=CeldaT1></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaT2></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaT3></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaT4></td>"
        '                strDesgloceCoberturas &= " </tr>"

        '                For z As Integer = 1 To intContadorCoberturas
        '                    xnlnCoberturas = xmlSalida.ChildNodes(1).ChildNodes(0).SelectNodes("vehiculo").Item(0).ChildNodes(z - 1)
        '                    If xnlnCoberturas.OuterXml.Substring(0, 10).Equals("<cobertura") Then
        '                        strDesgloceCoberturas &= "<tr>"
        '                        strDesgloceCoberturas &= "<td class=Celda1>" & xnlnCoberturas.Attributes("desc").InnerText & "</td>"
        '                        strDesgloceCoberturas &= "<td class=Celda2>" & xnlnCoberturas.Attributes("sa").InnerText & "</td>"
        '                        strDesgloceCoberturas &= "<td class=Celda3>" & xnlnCoberturas.Attributes("ded").InnerText & "</td>"

        '                        strDesgloceCoberturas &= "<td class=Celda4>" & IIf(xnlnCoberturas.Attributes("pma").InnerText.Trim.Length = 0, "", "$") & "&nbsp;"
        '                        If xnlnCoberturas.Attributes("pma").InnerText.Trim.Length = 0 Then
        '                            strDesgloceCoberturas &= "</td>"
        '                        Else
        '                            If separadorDecimal = "," Then
        '                                strDesgloceCoberturas &= MyFormatNumber((xnlnCoberturas.Attributes("pma").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", ".")) & "</td>"
        '                            Else
        '                                strDesgloceCoberturas &= MyFormatNumber(xnlnCoberturas.Attributes("pma").InnerText * factor) & "</td>"
        '                            End If
        '                        End If

        '                        strDesgloceCoberturas &= "</tr>"
        '                        strDesgloceCoberturas &= "<tr>"
        '                        strDesgloceCoberturas &= "    <td class=CeldaR1></td>"
        '                        strDesgloceCoberturas &= "    <td class=CeldaR2></td>"
        '                        strDesgloceCoberturas &= "    <td class=CeldaR3></td>"
        '                        strDesgloceCoberturas &= "    <td class=CeldaR4></td>"
        '                        strDesgloceCoberturas &= " </tr>"
        '                    End If
        '                Next

        '                strDesgloceCoberturasTemp = strDesgloceCoberturas & "</table>"
        '                'strDesgloceCoberturasTemp &= "</br>"

        '                If separadorDecimal = "," Then
        '                    TempXprimaNeta = MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primaneta").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", "."))
        '                    TempXderecho = MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("derecho").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", "."))
        '                    TempXrecargo = MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("recargo").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", "."))
        '                    TempXimpuesto = MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("impuesto").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", "."))
        '                    TempXprimaTotal = MyFormatNumber((xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText.Replace(",", "").Replace(".", ",") * factor).Replace(",", "."))
        '                Else
        '                    TempXprimaNeta = MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primaneta").InnerText * factor)
        '                    TempXderecho = MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("derecho").InnerText * factor)
        '                    TempXrecargo = MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("recargo").InnerText * factor)
        '                    TempXimpuesto = MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("impuesto").InnerText * factor)
        '                    TempXprimaTotal = MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText * factor)
        '                End If


        '                'strDesgloceCoberturasTemp &= "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prima Neta :&nbsp;" & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primaneta").InnerText * factor) & ""
        '                'strDesgloceCoberturasTemp &= "<BR/>"
        '                'strDesgloceCoberturasTemp &= "<BR/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Derecho :&nbsp;" & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("derecho").InnerText * factor) & ""
        '                'strDesgloceCoberturasTemp &= "<br/>"
        '                'strDesgloceCoberturasTemp &= "<tr><td></td><td></td><td></td><td></td></tr>"
        '                'strDesgloceCoberturasTemp &= "<tr><td>&nbsp;</td><td>&nbsp;</td><td align=right>Recargo :</td><td align=right>" & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("recargo").InnerText * factor) & "</td></tr>"
        '                'strDesgloceCoberturasTemp &= "<tr><td></td><td></td><td></td><td></td></tr>"
        '                'strDesgloceCoberturasTemp &= "<tr><td>&nbsp;</td><td>&nbsp;</td><td align=right>Impuesto :</td><td align=right>" & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("impuesto").InnerText * factor) & "</td></tr>"
        '                'strDesgloceCoberturasTemp &= "<tr><td></td><td></td><td></td><td></td></tr>"
        '                'strDesgloceCoberturasTemp &= "<tr><td>&nbsp;</td><td>&nbsp;</td><td align=right>Prima Total :</td><td align=right>" & MyFormatNumber(xmlSalida.ChildNodes(1).ChildNodes(0).ChildNodes(3).Attributes("primatotal").InnerText * factor) & "</td></tr>"


        '                strDesgloceCoberturas &= "<tr>"
        '                strDesgloceCoberturas &= "    <td class=CeldaP1></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaP2></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaP3></td>"
        '                strDesgloceCoberturas &= "    <td class=CeldaP4></td>"
        '                strDesgloceCoberturas &= " </tr>"
        '                strDesgloceCoberturas &= "</table>"

        '                Select Case intCobertura
        '                    Case 1
        '                        strCoberturaDet1 = strDesgloceCoberturas
        '                        strCoberturaDet11 = strDesgloceCoberturasTemp
        '                    Case 2
        '                        strCoberturaDet2 = strDesgloceCoberturas
        '                        strCoberturaDet21 = strDesgloceCoberturasTemp
        '                    Case 3
        '                        strCoberturaDet3 = strDesgloceCoberturas
        '                        strCoberturaDet31 = strDesgloceCoberturasTemp
        '                    Case 4
        '                        strCoberturaDet4 = strDesgloceCoberturas
        '                        strCoberturaDet41 = strDesgloceCoberturasTemp
        '                    Case 5
        '                        strCoberturaDet5 = strDesgloceCoberturas
        '                        strCoberturaDet51 = strDesgloceCoberturasTemp
        '                    Case 6
        '                        strCoberturaDet6 = strDesgloceCoberturas
        '                        strCoberturaDet61 = strDesgloceCoberturasTemp
        '                End Select

        '            Else
        '                'MensajeError("No pude cotizar favor de volverlo a intentar")
        '                'OcultaCotizacion()
        '            End If
        '        End If
    End Sub

    Protected Function MyFormatNumber2(ByVal strValor As String, ByVal nQuincenas As Integer) As String
        If strValor.Trim.Length.Equals(0) Then
            Return ""
        End If

        strValor = FormatNumber((CDbl(strValor) / nQuincenas), 2, TriState.False, TriState.False, TriState.False)
        strValor = strValor.Replace(",", ".")
        Return strValor

    End Function
End Class
