function ajaxCall(endpoint, type, param, callback) {
    $(".ajax-loader").show();
    $.ajax({
        url: window.location.origin + endpoint,
        data: param,
        dataType: 'json',
        type: type,
        success: function (data) {
            $(".ajax-loader").hide();
            callback(data)
        },
        error: function (err) {
            $(".ajax-loader").hide();
        }
    })
}

function ajaxFormPost(endpoint, formData, callback, showLoader = true) {
    if (showLoader) {
        $(".ajax-loader").show();
    }
    $.post(endpoint, formData, function (data) {
        $(".ajax-loader").hide();
        callback(data);
    })
        .fail(function (response) {
            $(".ajax-loader").hide();
        });
}

var helper = {
    variable: {
        templateData: []
    },
    getFastSelectValue: function (ddl) {
        var arr = [];
        $("#" + ddl).prev().find(".fstChoiceItem").each(function (i, v) {
            arr.push($(v).attr('data-value'));
        });
        return arr.join(",");
    },

    fillCallStatus: function (ddl, leadStatus) {
        var allowedStatus = ["FollowUp", "Postpone", "Converted", "Comment"];
        if (leadStatus && leadStatus == "All") {
            allowedStatus.push('Reopen');
            allowedStatus.push('Closed');
        }
        else {
            if (leadStatus && leadStatus == "Closed") {
                allowedStatus = [];
                allowedStatus.push('Reopen');
            }
            else {
                allowedStatus.push('Closed');
            }
        }

        var str = '<option value=""></option>';
        $.each(allowedStatus, function (i, v) {
            str += '<option value="' + v + '">' + v + '</option>';
        });
        $(ddl).html(str);
    },

    fillCallRemarks: function (status, ddl) {
        var param = { status: status };
        var str = '<option value=""></option>';
        if (status) {
            ajaxCall("/LeadRemarks/GetByStatus", "GET", param, function (data) {
                $.each(data, function (i, v) {
                    str += '<option value="' + v.name + '">' + v.name + '</option>';
                });
                $("#" + ddl).html(str);
            });
        }
        else {
            $("#" + ddl).html(str);
        }
    },

    fillTextData: function (type, ddl) {
        var param = { type: type };
        var str = '<option value=""></option>';
        helper.variable.templateData = [];
        if (type) {
            ajaxCall("/Template/GetByType", "GET", param, function (data) {
                helper.variable.templateData = data;
                $.each(data, function (i, v) {
                    str += '<option value="' + v.id + '">' + v.name + '</option>';
                });
                $("#" + ddl).html(str);
            });
        }
        else {
            $("#" + ddl).html(str);
        }
    },

    getFormData: function ($form) {
        var unindexed_array = $form.serializeArray();
        var indexed_array = {};

        $.map(unindexed_array, function (n, i) {
            indexed_array[n['name']] = n['value'];
        });

        return indexed_array;
    },

    getTimeFormated: function () {
        var today = new Date(),
            h = today.getHours(),
            m = today.getMinutes(),
            s = today.getSeconds();
        return [h + ":" + m + ":" + s, h + ":" + m]
    },


    addErrorInForm: function (div, message) {
        $("#" + div).removeClass("validation-summary-valid");
        $("#" + div).removeClass("alert-success");
        $("#" + div).addClass("validation-summary-errors");
        $("#" + div).addClass("alert-danger");
        $("#" + div + " ul").html('');
        $.each(message, function (i, v) {
            $("#" + div + " ul").append("<li>" + v + "</li>");
        });
        helper.scrollToTop();
        helper.clearMessage(div);
    },

    addSuccessInForm: function (div, message) {
        $("#" + div).removeClass("validation-summary-valid");
        $("#" + div).removeClass("alert-danger");
        $("#" + div).addClass("validation-summary-errors");
        $("#" + div).addClass("alert-success");
        $("#" + div + " ul").html('');
        $.each(message, function (i, v) {
            $("#" + div + " ul").append("<li>" + v + "</li>");
        });
        $("#" + div).focus();
        helper.scrollToTop();
        helper.clearMessage(div);
    },

    scrollToTop: function () {
        window.scrollTo(0, 0);
    },

    clearMessage: function (div) {
        setTimeout(function () {
            $("#" + div).addClass("validation-summary-valid");
            $("#" + div).removeClass("validation-summary-errors");
        }, 5000);
    },

    parseLeadText: function (text) {
        Object.keys(leadJson).forEach(function (key) {
            var find = '@' + key + '@';
            text = text.replace(new RegExp(find, 'g'), leadJson[key]);
        })
        return text;
    }
}



var report = {
    reportTypeEnum: {
        Preview: 0,
        doc: 1,
        pdf: 2,
        xls: 3
    },

    reportFormTypeEnum: {
        Invoice: 0,
    },

    reportAction: function (id, reportFormType, reportType) {
        if (reportType == report.reportTypeEnum.Preview) {
            var param = {
                id: id,
                reportFormType: reportFormType,
                reportType: reportType
            };

            ajaxCall("/Report/InvoicePreview", "GET", param, function (data) {
                if (data && data.absoluteUrl) {
                    $("#invoiceModalPopup").modal('show');
                    $("#invoice-frame").attr('src', '/' + data.absoluteUrl);
                }
            });
        }
        else {
            var cacheBuster = new Date().getTime();
            var url = "/Report/InvoiceDownload?id=" + id + "&reportFormType=" + reportFormType + "&reportType=" + reportType + "&time=" + cacheBuster;
            $("#invoice-frame").attr('src', url);
        }
    },
};