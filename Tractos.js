var Tractos = {
    parametros: {
        nIdUsuario: 0,
        nValor: 0,
        nAdaptacion: 0,
        nTipoCotizacion: 0,
        strValores: "",
        nTipoCobranza: 0,
        cUsuarioSeg: "",
        cClaveSeg: "",
        nDescuento: 0,
        nRecargo: 0,
        nLinea: 1,
        nDiasRetro: 0,
        nDiasAnticipada: 0
    },
    AgregarFuncionesEvento: {
        TextoNumeros: function () {
            $("input[type=text][name=numeros]").keypress(function (event) {
                var tecla = (document.all) ? event.keyCode : event.which;
                if (tecla === 8 || tecla === 0) {
                    return;
                }
                var letra = /[0-9 . /]/.test(String.fromCharCode(tecla));
                return letra;
            });
        },
        FormatoPrima: function () {
            $("#TxtValorFactura").focusout(function (event){
                var num = $(this).val().replace(/\,/g,'');
                if(!isNaN(num)){
                    num = num.toString().split('').reverse().join('').replace(/(?=\d*\,?)(\d{3})/g,'$1,');
                    num = num.split('').reverse().join('').replace(/^[\,]/,'');
                    $(this).val(num);
                }  
            });

            $("#TxtValorAdaptacion").focusout(function (event) {
                var num = $(this).val().replace(/\,/g, '');
                if (!isNaN(num)) {
                    num = num.toString().split('').reverse().join('').replace(/(?=\d*\,?)(\d{3})/g, '$1,');
                    num = num.split('').reverse().join('').replace(/^[\,]/, '');
                    $(this).val(num);
                }
            });
        },
        FormatoPrima2: function () {
            $("[name=TxtValor]").unbind("focusout").focusout(function (event) {
                var num = $(this).val().replace(/\,/g, '');
                if (!isNaN(num)) {
                    num = num.toString().split('').reverse().join('').replace(/(?=\d*\,?)(\d{3})/g, '$1,');
                    num = num.split('').reverse().join('').replace(/^[\,]/, '');
                    $(this).val(num);
                }
            });
        },
        TxtDescuento: function () {
            $("#TxtDescuento").keypress(function (event) {
                var tecla = (document.all) ? event.keyCode : event.which;
                if (tecla === 8 || tecla === 0) {
                    return;
                }
                var letra = /[0-9 . /]/.test(String.fromCharCode(tecla));

                if ($(this).val().indexOf(".") > -1) {
                    var valor = $(this).val().split(".");

                    if (tecla === 46) {
                        return false;
                    } else {
                        if (valor[1].length < 2) {
                            return letra;
                        } else {
                            return false;
                        }
                    }
                } else {
                    if ($(this).val().length == 2) {
                        $(this).val($(this).val() + ".");
                        return letra;
                    } else {
                        return letra;
                    }
                }
                
            });
        },
        TextoNumYLetras: function () {
            $("input[type=text][name=numletras]").keypress(function (event) {
                var tecla = (document.all) ? event.keyCode : event.which;
                if (tecla === 8 || tecla === 0) {
                    return;
                }
                var letra = /[0-9 A-Z a-z . ÁÉÍÓÚÑ áéíóúñ -]/.test(String.fromCharCode(tecla));
                return letra;
            });
        },
        ChkRecargo: function () {
            $("#ChkRecargo").change(function (event) {
                $("#pnlPresentaCotizacion").hide();
            });
        },
        ChkVF: function () {
            $("#ChkVF").unbind('on').on('ifChanged', function (event) {
                var nValorFactura = 0;
                if ($("#ChkVF").is(":checked")) {
                    nValorFactura = 1;
                    $("#SpValor").html("Valor Factura");
                } else {
                    $("#SpValor").html("Valor Convenido");
                }

                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "CargaModelo",
                        nValorFactura: nValorFactura,
                        cLlave: Tractos.GetUrlParam("id")[0]
                    },
                    success: function (data) {
                        eval(data);
                    },
                    dataType: "text",
                    async: true
                });

                $("#pnlPresentaCotizacion").hide();
            });
        },
        FechaInFin: function () {
            var dAnticipada = new Date();
            var dRetro = new Date();
            var dhoy = new Date();
            dAnticipada.setHours(dAnticipada.getHours() + ((Tractos.parametros.nDiasAnticipada * 24) + 1));
            dRetro.setHours(dRetro.getHours() - ((Tractos.parametros.nDiasRetro * 24) + 1));

            $("#TxtVigencia").datepicker({
                dateFormat: "dd-mm-yy",
                monthNamesShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"],
                dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"],
                changeMonth: true,
                changeYear: true,
                numberOfMonths: 1,
                minDate: dRetro,
                maxDate: dAnticipada,
                defalutDate: 0,
                onClose: function (selectedDate) {                    
                    var date2 = $("#TxtVigencia").datepicker('getDate');
                    var Meses = $("#CmbVigencia2").val().split(" ");
                    date2.setMonth(date2.getMonth() + parseInt(Meses));
                    $("#TxtFinVigencia").datepicker('setDate', date2);
                }
            }).click(function () {
                $(this).blur();
            });

            $("#TxtVigencia").datepicker('setDate', dhoy);

            $("#TxtFinVigencia").datepicker({
                dateFormat: "dd-mm-yy",
                monthNamesShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"],
                dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"],
                changeMonth: true,
                changeYear: true,
                numberOfMonths: 1,
                onClose: function (selectedDate) {
                    //$("#TxtInicioVig").datepicker("option", "maxDate", selectedDate);
                }
            }).click(function () {
                $(this).blur();
            });
        },
        LimpiarCotizacion: function () {
            $("select[nCambio=1]").change(function (event) {
                $("#pnlPresentaCotizacion").hide();
            });

            $("[type=text][nCambio=1]").focusout(function (event) {
                $("#pnlPresentaCotizacion").hide();
            });
        },
        CmbVigencia: function () { 
            $("#CmbVigencia2").change(function (event) {
                var date1 = new Date();
                var Meses = $(this).val().split(" ");
                date1.setMonth(date1.getMonth() + parseInt(Meses));
                $("#TxtFinVigencia").datepicker('setDate', date1);
            });
        },
        CmbTipoPoliza: function () {
            $("#CmbTipoPoliza").unbind('change').change(function (event) {               
                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "CargaVigencia",
                        nTipoPoliza: $("#CmbTipoPoliza").val(),
                        cLlave: Tractos.GetUrlParam("id")[0]
                    },
                    success: function (data) {
                        eval(data);
                    },
                    dataType: "text",
                    async: true
                });
            });
        },
        CmbMoneda: function () {
            $("#CmbMoneda").unbind('change').change(function (event) {
                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "cargaNuevosCombos",
                        Moneda: $("#CmbMoneda").val(),
                        cLlave: Tractos.GetUrlParam("id")[0]
                    },
                    success: function (data) {
                        eval(data);
                    },
                    dataType: "text",
                    async: true
                });

                var cClave = $("#CmbSubMarca").val().split(" ")

                if ($(this).val() == "00") {
                    switch(cClave[0]) {
                        case "60000606":
                            Tractos.parametros.nValor = 250000;
                            break;
                        case "60000607":
                            Tractos.parametros.nValor = 125000;
                            break;
                        case "60000608":
                            Tractos.parametros.nValor = 700000;
                            break;
                        default:
                            Tractos.parametros.nValor = 2000000;
                            break;
                    }
                } else {
                    switch (cClave[0]) {
                        case "60000606":
                            Tractos.parametros.nValor = 25000;
                            break;
                        case "60000607":
                            Tractos.parametros.nValor = 12500;
                            break;
                        case "60000608":
                            Tractos.parametros.nValor = 70000;
                            break;
                        default:
                            Tractos.parametros.nValor = 200000;
                            break;
                    }
                }
            });           
        },
        CmbDanosCarga: function () {
            $("#CmbDanosCarga").unbind("change").change(function (event) {
                if ($(this).val() == "EXCLUIDA") {
                    $("#TxtDescripcionCarga").val("").attr('disabled', true).addClass('ui-state-disabled').removeClass("Requerido").removeClass("ui-state-error ui-state-error-text");

                    $("#CmbRCEco").attr('disabled', true).addClass('ui-state-disabled').removeClass('Requerido').removeClass("ui-state-error ui-state-error-text");
                    $("#CmbDeducibleRCEco").attr('disabled', true).addClass('ui-state-disabled');
                    $("#CmbRCEco").val("EXCLUIDA");
                } else {
                    $("#TxtDescripcionCarga").attr('disabled', false).removeClass('ui-state-disabled').addClass("Requerido");

                    if ($(this).val() == "CARGA C-Alt Peligrosa") {
                        $("#CmbRCEco").attr('disabled', false).removeClass('ui-state-disabled').addClass('Requerido');
                        $("#CmbDeducibleRCEco").attr('disabled', false).removeClass('ui-state-disabled');
                    } else {
                        $("#CmbRCEco").attr('disabled', true).addClass('ui-state-disabled').removeClass('Requerido').removeClass("ui-state-error ui-state-error-text");
                        $("#CmbDeducibleRCEco").attr('disabled', true).addClass('ui-state-disabled');
                        $("#CmbRCEco").val("EXCLUIDA");
                    }
                }
            });
        },

        CmbGrua: function () {
            $("#CmbGrua").unbind("change").change(function (event) {
                if ($(this).val() == "EXCLUIDA") {
                    $("#CmbDeducibleGrua").val("EXCLUIDA");
                    $("#CmbDeducibleGrua").removeClass("Requerido");
                    $("#CmbGrua").removeClass("Requerido");
                } else {
                    $("#CmbDeducibleGrua").addClass("Requerido");
                }
            });
        },

        CmbDeducibleGrua: function () {
            $("#CmbDeducibleGrua").unbind("change").change(function (event) {
                if ($(this).val() == "EXCLUIDA") {
                    $("#CmbGrua").val("EXCLUIDA");
                    $("#CmbGrua").removeClass("Requerido");
                    $("#CmbDeducibleGrua").removeClass("Requerido");
                } else {
                    $("#CmbGrua").addClass("Requerido");
                }
            });
        },

        BtnCotizar: function () {
            $("#BtnCotizar").unbind("click").click(function (event) {
                if(!Tractos.ValidaRequeridos("#dvCotizador")){
                    Tractos.Cotizar("C");
                }
            });
        },

        BtnEnvia: function () {
            $("#BtnEnvia").unbind("click").click(function (event) {
                if (!Tractos.ValidaRequeridos("#dvEmision")) {
                    Tractos.Cotizar("E");
                }
            });
        },

        CmbEstado: function () {
            $("#CmbEstado").unbind("change").change(function (event) {
                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "CargaMunicipio",
                        nEstado: $(this).val()
                    },
                    success: function (data) {
                        eval(data);
                        $("#TxtEstado").val($("#CmbEstado option:selected").text());
                    },
                    dataType: "text",
                    async: true
                });
            });
        },
        CmbMunicipio: function () {
            $("#cmbMunicipio").unbind("change").change(function (event) {
                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "CargaCodigoPostal",
                        nEstado: $("#CmbEstado").val(),
                        nMunicipio: $(this).val()
                    },
                    success: function (data) {
                        eval(data);
                        $("#TxtMunicipio").val($("#cmbMunicipio option:selected").text());

                    },
                    dataType: "text",
                    async: true
                });
            });
        },
        CmbCodigoPostal: function () {
            $("#CmbCodigoPostal").unbind("change").change(function (event) {
                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "CargaColonia",
                        nEstado: $("#CmbEstado").val(),
                        nMunicipio: $("#cmbMunicipio").val(),
                        cCodigoPostal: $(this).val()
                    },
                    success: function (data) {
                        eval(data);                        
                    },
                    dataType: "text",
                    async: true
                });
            });
        },
        CmbTipoPago: function () {
            $("#CmbTipoPago").unbind("change").change(function (event) {
                if ($(this).val() == 0) {
                    $("[name=trTarjeta]").show();
                    $("[name=trTarjeta]").find("input[type=text]").addClass("Requerido");
                } else {
                    $("[name=trTarjeta]").hide();
                    $("[name=trTarjeta]").find("input[type=text]").removeClass("Requerido");
                }
            });
        },
        TxtFecha: function () {
            $("[name=TxtFecha]").datepicker({
                dateFormat: "dd-mm-yy",
                monthNamesShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"],
                dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"],
                changeMonth: true,
                changeYear: true,
                yearRange: '-100:+0',
                numberOfMonths: 1
            }).click(function () {
                $(this).blur();
            });
        },
        CmbSubMarca: function () {
            $("#CmbSubMarca").unbind("change").change(function (event) {
                $("#TxtAutomovil").val($("#CmbSubMarca option:selected").text());

                $.ajax({
                    type: 'POST',
                    url: '../DataProviders/Tracto.aspx',
                    data: {
                        servicio: "ValorMaximoVehiculo",
                        cLlave: Tractos.GetUrlParam("id")[0],
                        cSubmarca: $(this).val()
                    },
                    success: function (data) {
                        eval(data);
                    },
                    dataType: "text",
                    async: true
                });
            });
        },

        BtnComprar: function () {
            $("#BtnComprar").unbind("click").click(function (event) {
                
                $("#dvCotizador").hide();
                $("#pnlPresentaCotizacion").hide();
                $("#dvEmision").show();
                if ($("#TxtValorAdaptacion").val() != "") {
                    $("#GrdAdaptacion").show();
                }
            });
        },
        BtnRegresa: function () {
            $("#BtnRegresa").unbind("click").click(function (event) {
                $("#dvCotizador").show();
                $("#pnlPresentaCotizacion").show();
                $("#dvEmision").hide();
            });
        },
        CmbTipoPersona: function () {
            $("#CmbTipoPersona").unbind("change").change(function (event) {

                if ($(this).val() == 1) {
                    $("[nPersona=1]").show();
                    $("[nPersona=1]").find("input").addClass("Requerido");
                    $("[nPersona=1]").find("select").addClass("Requerido");
                    $("[nPersona=2]").hide();
                    $("[nPersona=2]").find("input").removeClass("Requerido");
                    $("[nPersona=2]").find("select").removeClass("Requerido");
                    $("[name=Nacionalidad]").show();
                } else {
                    $("[nPersona=2]").show();
                    $("[nPersona=2]").find("input").addClass("Requerido");
                    $("[nPersona=2]").find("select").addClass("Requerido");
                    $("[nPersona=1]").hide();
                    $("[nPersona=1]").find("input").removeClass("Requerido");
                    $("[nPersona=1]").find("select").removeClass("Requerido");
                    $("[name=Nacionalidad]").hide();
                }               
            });
        },
        CmbFormaPago: function () {
            $("#CmbTipoPersona").unbind("change").change(function (event) {
                $("#TxtFormapago").val($("#CmbTipoPersona option:selected").text());
            });
        },
        Cotizar: function () {
            $("#Cotizar").unbind("click").click(function (event) {
                $("#dvCotizador").show();
                $("#dvBienvenida").hide();
            });
        },
        BtnBuscar: function () {
            $("#BtnBuscar").unbind("click").click(function (event) {
                if ($("#TxtBuscarRFC").val() == "") {
                    $("#TxtBuscarRFC").addClass("ui-state-error ui-state-error-text").effect("pulsate");
                } else {
                    $("#TxtBuscarRFC").removeClass("ui-state-error ui-state-error-text");

                    $.ajax({
                        type: 'POST',
                        url: '../DataProviders/Tracto.aspx',
                        data: {
                            servicio: "BuscarCliente",
                            cRFC: $("#TxtBuscarRFC").val()
                        },
                        success: function (data) {
                            eval(data);
                            
                        },
                        dataType: "text",
                        async: true
                    });
                
                }                
            });
        },
        BtnAgregarLinea: function () {
            $("#BtnAgregarLinea").unbind("click").click(function (event) {
                Tractos.parametros.nLinea += 1;
                var HTML = ""

                HTML += "<tr nLinea='" + Tractos.parametros.nLinea + "'>";
                HTML += "<td>Valor: $ <input name='TxtValor' nLinea='" + Tractos.parametros.nLinea + "' /> </td>";
                HTML += "<td>Descripción: <input name='TxtDescripcion' nLinea='" + Tractos.parametros.nLinea + "'/> </td>";
                HTML += "<td>";
                HTML += "<input type='button' name='BtnEliminarLinea' value='-' nLinea='" + Tractos.parametros.nLinea + "' class='BtnRojo' style='display:none' />";
                HTML += "<input type='button' id='BtnAgregarLinea' value='+' class='BtnRojo' />";
                HTML += "</td>";
                HTML += "</tr>";

                $("[name=BtnEliminarLinea]").show();
                $("#BtnAgregarLinea").remove();
                $("#GrdAdaptacion").append(HTML);

                Tractos.AgregarFuncionesEvento.BtnAgregarLinea();
                Tractos.AgregarFuncionesEvento.BtnEliminarLinea();
                Tractos.AgregarFuncionesEvento.FormatoPrima2();
            });            
        },
        BtnEliminarLinea: function () {
            $("[name=BtnEliminarLinea]").unbind("click").click(function () {
                $("[nLinea=" + $(this).attr("nLinea") + "]").remove();
            });
        }
    },
    Iniciar: function () {
        if (Tractos.GetUrlParam("nTipo")[0] == 2) {
            $.ajax({
                type: 'POST',
                url: '../DataProviders/Tracto.aspx',
                data: {
                    servicio: "ConsultaSession"
                },
                success: function (data) {
                    eval(data);

                    if (vbSession) {
                        $("#dvLogIn").hide();
                        $("#dvCotizador").show();
                    } else {
                        $("#dvLogIn").show();
                        //$("#dvCotizador").hide();
                    }
                },
                dataType: "text",
                async: true
            });
        } else {
            $("#dvLogIn").hide();
            //$("#dvCotizador").show();
        }

        $('#ChkVF').iCheck({
            checkboxClass: 'icheckbox_square-red'
        });
        Tractos.AgregarFuncionesEvento.ChkVF();

        if (Tractos.ConstruyeNegocio()) {
            Tractos.AgregarFuncionesEvento.TxtFecha();
            Tractos.AgregarFuncionesEvento.CmbTipoPoliza();
            Tractos.AgregarFuncionesEvento.CmbDanosCarga();
            Tractos.AgregarFuncionesEvento.CmbEstado();
            Tractos.AgregarFuncionesEvento.CmbMunicipio();
            Tractos.AgregarFuncionesEvento.CmbCodigoPostal();
            Tractos.AgregarFuncionesEvento.CmbTipoPago();
            Tractos.AgregarFuncionesEvento.BtnCotizar();
            Tractos.AgregarFuncionesEvento.BtnComprar();
            Tractos.AgregarFuncionesEvento.BtnEnvia();
            Tractos.AgregarFuncionesEvento.CmbSubMarca();            
            Tractos.AgregarFuncionesEvento.LimpiarCotizacion();
            Tractos.AgregarFuncionesEvento.BtnRegresa();
            Tractos.AgregarFuncionesEvento.CmbFormaPago();
            Tractos.AgregarFuncionesEvento.Cotizar();
            //Tractos.AgregarFuncionesEvento.TxtDescuento();
            Tractos.AgregarFuncionesEvento.TextoNumeros();
            Tractos.AgregarFuncionesEvento.CmbTipoPersona();
            Tractos.AgregarFuncionesEvento.BtnBuscar();
            Tractos.AgregarFuncionesEvento.BtnAgregarLinea();
            Tractos.AgregarFuncionesEvento.BtnEliminarLinea();
            Tractos.AgregarFuncionesEvento.FormatoPrima();
            Tractos.AgregarFuncionesEvento.ChkRecargo();
            Tractos.AgregarFuncionesEvento.FormatoPrima2();
            $("#ChkRecargo").adaptiveSwitch();
            $("#CmbEstado").trigger("change");
            $("#CmbSubMarca").trigger("change");
            Tractos.AgregarFuncionesEvento.FechaInFin();
            Tractos.AgregarFuncionesEvento.CmbVigencia();
            Tractos.AgregarFuncionesEvento.CmbGrua();
            Tractos.AgregarFuncionesEvento.CmbDeducibleGrua();
            
        }
    },
    ConstruyeNegocio: function (){
        var cLlave = Tractos.GetUrlParam("id")[0];

        if (cLlave == "") {
            Tractos.Mensaje("No hay negocio que cargar, favor de revisar su URL.", 100, 100);
            return false;
        } else {
            $.ajax({
                type: 'POST',
                url: '../DataProviders/Tracto.aspx',
                data: {
                    servicio: 'ConstruyeNegocio',
                    cLlave: cLlave
                },
                success: function (data) {
                    try {
                        jQuery.globalEval(data);

                    } catch (e) {
                        console.log(e.message);
                    }
                },
                dataType: "text",
                async: false
            });
            return true;
        }
    },

    Cotizar: function (cTipo) {
        var nValorFactura = 0;
        var nRecargo = 0;
        if ($("#ChkVF").is(":checked")) {
            nValorFactura = 1;
        } 

        if ($("#ChkRecargo").is(":checked")) {
            nRecargo = 1;
        } 
        var Cotiza = true;
        var cAdaptaciones = "";

        if (cTipo == "E") {
            var nValorAdaptacionesTemp = 0;
            if ($("#TxtValorAdaptacion").val() != "") {
                for (i = 1; i < Tractos.parametros.nLinea + 1; ++i) {
                    if ($("[name=TxtValor][nLinea=" + i + "]").val() != "undefined") {
                        cAdaptaciones += $("[name=TxtValor][nLinea=" + i + "]").val() + "-";
                        cAdaptaciones += $("[name=TxtDescripcion][nLinea=" + i + "]").val() + "|";
                        nValorAdaptacionesTemp += parseFloat($("[name=TxtValor][nLinea=" + i + "]").val().replace(/,/g, ''));
                    }
                }
                if (parseFloat($("#TxtValorAdaptacion").val().replace(/,/g, '')) != nValorAdaptacionesTemp) {
                    Cotiza = false;
                }
            }
        }

        if (Cotiza){
            $.ajax({
                type: 'POST',
                url: '../DataProviders/Tracto.aspx',
                data: {
                    servicio: "Cotizar",
                    cLlave: Tractos.GetUrlParam("id")[0],
                    cTipo: cTipo,
                    nValorFactura: nValorFactura,
                    cMoneda: $("#CmbMoneda").val(),
                    nTipoPoliza: $("#CmbTipoPoliza").val(),
                    nModelo: $("#CmbModelo").val(),
                    nMarca: $("#CmbMarca").val(),
                    cSubMarca: $("#CmbSubMarca").val(),
                    cDescripcion: $("#CmbMarca option:selected").text() + " - " + $("#TxtDescripcion").val(),
                    cValorFactura: $("#TxtValorFactura").val(),
                    cValorAdaptacion: $("#TxtValorAdaptacion").val(),
                    nDD: $("#CmbDD").val(),
                    nDR: $("#CmbDR").val(),
                    cRCLUC: $("#CmbRCLUC").val(),
                    cDeducibleRCLUC: $("#CmbDeducibleRCLUC").val(),
                    cRCEco: $("#CmbRCEco").val(),
                    cDeducibleRCEco: $("#CmbDeducibleRCEco").val(),
                    cGrua: $("#CmbGrua").val(),
                    cDeducibleGrua: $("#CmbDeducibleGrua").val(),
                    cDobleSemiremolque: $("#CmbDobleSemiremolque").val(),
                    cRCCatastroficaT: $("#cmbRCCatastroficaT").val(),
                    cGM: $("#CmbGM").val(),
                    cMuerteAccidentalT: $("#CmbMuerteAccidentalT").val(),
                    cDanosCarga: $("#CmbDanosCarga").val(),
                    cDescripcionCarga: $("#TxtDescripcionCarga").val(),
                    cVigencia: $("#CmbVigencia2").val(),
                    cFormaPago: $("#CmbFormaPago").val(),
                    nEstado: $("#CmbEstado").val(),
                    nMunicipio: $("#cmbMunicipio").val(),                
                    nTipoPersona: $("#CmbTipoPersona").val(),
                    cPaterno: $("#TxtPaterno").val(),
                    cMaterno: $("#TxtMaterno").val(),
                    cNombre: $("#TxtNombre").val(),
                    cFIEL: $("#TxtFIEL").val(),
                    cFecNaci: $("#TxtFecNaci").val(),
                    cPais: $("#TxtPais").val(),
                    cEmail: $("#TxtEmail").val(),
                    cTelefono: $("#TxtTelefono").val(),
                    cRFC: $("#TxtRFC").val(),
                    cCURP: $("#TxtCURP").val(),
                    cNacionalidad: $("#CmbNacionalidad").val(),
                    nTipoIdentificacion: $("#CmbIdentificacion").val(),
                    nIdentificacion: $("#TxtNoIdentificacion").val(),
                    cOcupacion: $("#CmbOcupacion").val(),
                    cCalle: $("#TxtCalle").val(),
                    cNoExt: $("#TxtNoExt").val(),
                    cNoInt: $("#TxtNoInt").val(),
                    cCodigoPostal: $("#CmbCodigoPostal").val(),
                    cColonia: $("#CmbColonia").val(),
                    cConductor: $("#TxtConductor").val(),
                    cNacimientoConductor: $("#TxtNacimientoConductor").val(),
                    cLicenciaConductor: $("#TxtLicenciaConductor").val(),
                    cSerie: $("#TxtSerie").val(),
                    cMotor: $("#TxtMotor").val(),
                    cPlacas: $("#TxtPlacas").val(),
                    cRepuve: $("#TxtRepuve").val(),
                    cColor: $("#CmbColor").val(),
                    cBeneficiarioPreferente: $("#TxtBeneficiarioPreferente").val(),
                    nTipoPago: $("#CmbTipoPago").val(),
                    cNombreTarjeta: $("#TxtNombreTarjeta").val(),
                    cCodigoSeguridad: $("#TxtCodigoSeguridad").val(),
                    cNumeroTarjeta: $("#TxtNumeroTarjeta").val(),
                    cMes: $("#CmbMes").val(),
                    cAno: $("#CmbAno").val(),
                    cRazon: $("#TxtRazon").val(),
                    nDescuento: $("#TxtDescuento").val(),
                    cAdaptaciones: cAdaptaciones,
                    dInicio: $("#TxtVigencia").val(),
                    dTermino: $("#TxtFinVigencia").val(),
                    nRecargo: nRecargo,
                    cRepresentante: $("#TxtRepresentante").val(),
                    cNacionalidadR: $("#CmbNacionalidadR").val(),
                    cAdministrador: $("#TxtAdministrador").val(),
                    cNacionalidadA: $("#CmbNacionalidadA").val(),
                    nGiro: $("#CmbGiro").val(),
                    nColor: $("#CmbColor").val()
                },
                success: function (data) {
                    eval(data);
                },
                dataType: "text",
                async: true
            });
        } else {
            Tractos.Mensaje("El valor de las adaptaciones no coinciden con el cotizado, favor de revisar.", 100, 100);
        }
    },

    ValidaRequeridos: function (Formulario) {
        var Requeridos = false;
        var MensajeError = "";

        if (parseFloat($("#TxtValorFactura").val().replace(/,/g, '')) > parseFloat(Tractos.parametros.nValor)) {
            Requeridos = true;
            $("#TxtValorFactura").addClass("ui-state-error ui-state-error-text").effect("pulsate");
            MensajeError += "El valor de la unidad excede lo autorizado. <br />";
        } else {
            $("#TxtValorFactura").removeClass("ui-state-error ui-state-error-text");
        }

        if (parseFloat($("#TxtValorFactura").val().replace(/,/g, '')) < parseFloat(10000)) {
            Requeridos = true;
            $("#TxtValorFactura").addClass("ui-state-error ui-state-error-text").effect("pulsate");
            MensajeError += "El valor de la unidad es menor a lo autorizado. <br />";
        } else {
            $("#TxtValorFactura").removeClass("ui-state-error ui-state-error-text");
        }

        if (parseFloat($("#TxtValorAdaptacion").val().replace(/,/g, '')) > parseFloat(Tractos.parametros.nAdaptacion)) {
            Requeridos = true;
            $("#TxtValorAdaptacion").addClass("ui-state-error ui-state-error-text").effect("pulsate");
            MensajeError += "La adapatación excede lo autorizado. <br />";
        } else {
            $("#TxtValorAdaptacion").removeClass("ui-state-error ui-state-error-text");
        }

        if ($("#ChkRecargo").is(":checked")) {
            if (parseFloat($("#TxtDescuento").val()) > parseFloat(Tractos.parametros.nRecargo)) {
                Requeridos = true;
                $("#TxtDescuento").addClass("ui-state-error ui-state-error-text").effect("pulsate");
                MensajeError += "El recargo excede al autorizado. <br />";
            } else {
                $("#TxtDescuento").removeClass("ui-state-error ui-state-error-text");
            }
        } else {
            if (parseFloat($("#TxtDescuento").val()) > parseFloat(Tractos.parametros.nDescuento)) {
                Requeridos = true;
                $("#TxtDescuento").addClass("ui-state-error ui-state-error-text").effect("pulsate");
                MensajeError += "El descuento excede al autorizado. <br />";
            } else {
                $("#TxtDescuento").removeClass("ui-state-error ui-state-error-text");
            }
        }


        if (Requeridos) {
            Tractos.Mensaje(MensajeError, 100, "auto");
        }
        $(Formulario).find(".Requerido").each(function (index) {
            var $this = $(this);

            switch ($this.prop("tagName")) {
                case "SELECT":
                    if ($this.is(":visible")) {
                        if (($this.val() == "0") || ($this.val() == "") || ($this.val() == "-- SELECCIONAR --") || ($this.val() == "EXCLUIDA")) {
                            Requeridos = true;
                            $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                        } else {
                            $this.removeClass("ui-state-error ui-state-error-text");
                        }
                    } else {
                        $this.removeClass("ui-state-error ui-state-error-text");
                    }
                    break;
                case "INPUT":
                    switch ($this.attr("Name")) {
                        case "email": //placeholder
                            //$this.removeAttr("title");
                            $this.removeClass("ui-state-error ui-state-error-text");
                            if ($this.val().length) {
                                if (!ComplementoAjustador.ValidaEspeciales.mail($this.val())) {
                                    Requeridos = true;
                                    $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                                }
                            } else {
                                //$this.addClass("ui-state-error ui-state-error-text").effect("pulsate").attr("title", "VACIO - NO REQUERIDO").tooltip();
                            }
                            break;
                        default:
                            if (($this.attr("type") == "text") || ($this.attr("type") == "password")) {
                                if ($this.is(":visible")) {
                                    if (($this.val().length == 0) || ($this.attr("placeholder") == $this.val())) {
                                        Requeridos = true;
                                        $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                                    } else {
                                        if ($this.hasClass("ExtraRequerido")) {
                                            if ($this.val() == 0) {
                                                Requeridos = true;
                                                $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                                            } else {
                                                $this.removeClass("ui-state-error ui-state-error-text");
                                            }

                                        } else {
                                            $this.removeClass("ui-state-error ui-state-error-text ");
                                        }
                                    }
                                } else {
                                    $this.removeClass("ui-state-error ui-state-error-text ");
                                }
                            }
                            break;
                    }
                    break;
                case "TEXTAREA":
                    if ($this.val().length == 0) {
                        Requeridos = true;
                        $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                        $(".cleditorMain").find("iframe").hide();
                    } else {
                        $this.removeClass("ui-state-error ui-state-error-text");
                    }
                    break;
                case "TABLE":
                    if ($this.find("input:checked").length == 0) {
                        Requeridos = true;
                        $this.addClass("ui-state-error ui-state-error-text").effect("pulsate");
                    } else {
                        $this.removeClass("ui-state-error ui-state-error-text");
                    }
                    break;
                default:
                    jQuery.noop();
                    break;
            }
        });        

        return Requeridos
    },
    Mensaje: function (mensaje, w, h) {
        $("<div>" + mensaje + "</div>").dialog({
            title: "Aviso!",
            height: h,
            minWidth: w,
            modal: true,
            resizable: false,
            show: "blind",
            hide: "blind",
            open: function () {
            },
            close: function () {
                $(this).remove();
            }
        });
    },
    GetUrlParam: function () {
        var data = [];
        try {
            for (x = 0; x < arguments.length; ++x)
                data.push(location.href.match(new RegExp("/\?".concat(arguments[x], "=", "([^\n&]*)")))[1]);
            return data;
        }
        catch (err) {
            data[0] = "";
            return data;
        }
    }
}

$(document).ready(function () {
    Tractos.Iniciar();
});

