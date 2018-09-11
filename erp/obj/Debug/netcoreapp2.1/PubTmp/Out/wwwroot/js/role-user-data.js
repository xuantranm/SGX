﻿$(function () {
    loadEmployees();
    
    $('#part').on('change', function () {
        loadEmployees();
    });
    $('#department').on('change', function () {
        loadEmployees();
    });
    $('#title').on('change', function () {
        loadEmployees();
    });

    $('#user').on('change', function () {
        $('input[name="RoleUser.FullName"]').val($("#user option:selected").text());
    });

    $('.datepicker').on('changeDate', function () {
        var date = moment($(this).datepicker('getFormattedDate'), 'DD-MM-YYYY')
        $('.hidedatepicker', $(this).closest('.form-group')).val(
            date.format('MM-DD-YYYY')
        );
    });

    $('.addRoleUser').click(function (e) {
        var listRole = [];
        $('.select-role').each(function (i, obj) {
            listRole.push($(obj).val());
        });
        e.preventDefault();
        var code = parseInt($('.codeRoleUser:last').val()) + 1;
        var data = [
            {
                "code": code
            }
        ];
        $('.nodeRoleUser:last').after($.templates("#tmplRoleUser").render(data));
        for (var i = 0; i < listRole.length; i++) {
            $(".select-role:last option[value='" + listRole[i] +"']").remove();
        }
        registerDatePicker();
        enableRemove();
    });

    $(".data-form").on("submit", function (event) {
        event.preventDefault();
        //grab all form data  
        var formData = new FormData($(this)[0]);

        //console.log(formData);
        var $this = $(this);
        //var frmValues = $this.serialize();
        $.ajax({
            type: $this.attr('method'),
            url: $this.attr('action'),
            enctype: 'multipart/form-data',
            processData: false,  // Important!
            contentType: false,
            data: formData
        })
            .done(function (data) {
                if (data.result === true) {
                    $('#resultModal').modal();
                    $('#modalnotice').html($.templates("#tmplModalNotice").render(data));
                }
                else {
                    toastr.error(data.message);
                }
            })
            .fail(function () {
                toastr.error(data.message)
            });
        event.preventDefault();
    });
});

function loadEmployees() {
    var tmplEmployees = $.templates("#employeesTmpl"); // Get compiled template
    $.ajax({
        url: '/api/employee-filter',
        type: 'GET',
        data: {
            part: $('#part').val(),
            department: $('#department').val(),
            title: $('#title').val()
        },
        datatype: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.length !== 0) {
                if (data.length > 0) {
                    var htmlEmployees = tmplEmployees.render(data);      // Render template using data - as HTML string
                    $("#user").html(htmlEmployees);
                    $('input[name="RoleUser.FullName"]').val($("#user option:selected").text());
                    //$("#user").prepend($('<option value="" selected>Tất cả</option>'));
                }
            }
        }
    });
}

