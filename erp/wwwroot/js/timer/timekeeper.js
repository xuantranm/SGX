﻿$(function () {
    $('.js-select2-basic-single').select2(
        {
            theme: "bootstrap"
        });

    $('.ddl-times').on('change', function (e) {
        formSubmit();
    });

    $('.ddl-employees').on('change', function (e) {
        formSubmit();
    });

    $('#requestTimeKeeperModal').on('show.bs.modal', function (event) {
        var a = $(event.relatedTarget); // Button that triggered the modal
        var recipient = a.data('id'); // Extract info from data-* attributes
        var url = $('#hidUrlGetItem').val();
        var modal = $(this);
        $.ajax({
            type: "post",
            url: url,
            data: { id: recipient },
            success: function (data) {
                if (data.length !== 0) {
                    modal.find('.data-item-edit').html($.templates("#tmplDataItem").render(data));
                }
                $('.xac-nhan-cong-reason').on('change', function () {
                    changeReasonCong($(this));
                });
                $('textarea.js-auto-size').textareaAutoSize();
            }
        });
    });

    $(".data-form").on("submit", function (event) {
        event.preventDefault();
        var $this = $(this);
        var frmValues = $this.serialize();
        console.log(frmValues);

        $('.btn-submit-timekeeping').prop('disabled', true);
        var loadingText = '<i class="fas fa-spinner"></i> đang xử lý...';
        $('.btn-submit-timekeeping').html(loadingText);
        $.ajax({
            type: $this.attr('method'),
            url: $this.attr('action'),
            data: frmValues
        })
            .done(function (data) {
                if (data.result === true) {
                    toastr.success(data.message);
                    setTimeout(function () {
                        window.location.reload();
                    }, 1000);
                }
                else {
                    toastr.error(data.message);
                    $('.btn-submit-timekeeping').prop('disabled', false);
                    $('input', $('.data-form')).prop('disabled', false);
                    $('select', $('.data-form')).prop('disabled', false);
                    $('textarea', $('.data-form')).prop('disabled', false);
                    $('.btn-submit-timekeeping').html($('.btn-submit-timekeeping').data('original-text'));
                }
            })
            .fail(function () {
                toastr.error("Có lỗi xảy ra. Liên hệ hỗ trợ hotro@tribat.vn");
            });
    });

    function changeReasonCong(element) {
        if (element.val() === "Lý do khác") {
            $('.reason-description-3').removeClass('d-none');
        }
        else {
            $('.reason-description-3').addClass('d-none');
        }
        $.ajax({
            type: "post",
            url: $('#hidReasonRule').val(),
            data: {
                id: $('.hidLogId').val(),
                reason: element.val()
            },
            success: function (data) {
                console.log(data);
                if (data.error === 0) {
                    if (data.result === false) {
                        if (data.reason === "Quên chấm công") {
                            $('.reason-result-2').removeClass('d-none');
                            var displayLastApproved = "Ngày: " + DateFullToString(data.lastLogForget.date);
                            displayLastApproved += " , vào: " + NullToText(data.lastLogForget.in) + " , ra: " + NullToText(data.lastLogForget.out);
                            displayLastApproved += ". Duyệt bởi: " + data.lastLogForget.confirmName;
                            displayLastApproved += ", ngày gửi: " + DateFullToString(data.lastLogForget.requestDate);
                            $('.reason-detail-2-cancel').html(displayLastApproved);
                            $('.reason-detail').addClass('d-none');
                        }
                        else if (data.reason === "Lý do khác") {
                            $('.reason-result-3').removeClass('d-none');
                            var displayLastOtherRequest = "";
                            $.each(data.lastLogOther, function (key, value) {
                                console.log(value);
                                if (key > 0) {
                                    displayLastOtherRequest += "<br/>";
                                }
                                displayLastOtherRequest += key + 1 + ". Ngày: " + DateFullToString(value.date);
                                displayLastOtherRequest += " , vào: " + NullToText(value.in) + " , ra: " + NullToText(value.out);
                                displayLastOtherRequest += ". Duyệt bởi: " + value.confirmName;
                                displayLastOtherRequest += ", ngày gửi: " + DateFullToString(value.requestDate);
                            });

                            $('.reason-detail-3-cancel').html(displayLastOtherRequest);
                        }

                        $('.btn-submit-timekeeping').prop("disabled", true);
                        $('.ddl-approve-xac-nhan-cong')
                            .find('option')
                            .remove()
                            .end();
                        $('.ddl-approve-xac-nhan-cong')
                            .append($("<option></option>")
                                .attr("value", "")
                                .text("Chọn"));
                    }
                    else {
                        $('.reason-result-2').addClass('d-none');
                        $('.reason-result-3').addClass('d-none');
                        $('.ddl-approve-xac-nhan-cong')
                            .find('option')
                            .remove()
                            .end();
                        if (data.approves.length > 1) {
                            $('.ddl-approve-xac-nhan-cong')
                                .append($("<option></option>")
                                    .attr("value", "")
                                    .text("Chọn"));
                        }

                        $.each(data.approves, function (key, value) {
                            $('.ddl-approve-xac-nhan-cong')
                                .append($("<option></option>")
                                    .attr("value", value.id)
                                    .text(value.name));
                        });

                        if (element.val() !== "Quên chấm công") {
                            $('.reason-detail').removeClass('d-none');
                        } else {
                            $('.reason-detail').addClass('d-none');
                        }
                        $('.btn-submit-timekeeping').prop("disabled", false);
                    }
                }
            }
        });
    }

    function loadChart() {
        resetCanvas();
        var chartType = $('.chart-type').val() ? $('.chart-type').val() : "bar";
        var chartCategory = $('.chart-category').val();

        $.ajax({
            url: "/chart/datahr",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: {
                type: chartType,
                category: chartCategory
            },
            success: function (data) {
                console.log(data);
                $('.chart-name').text(data.title);
                $('.chart-info').text(data.info);
                datasets = [{
                    label: data.title,
                    data: data.data,
                    backgroundColor: data.backgroundColor,
                    borderColor: data.borderColor,
                    borderWidth: data.borderWidth
                }];
                var ctx = document.getElementById("chart");
                var config = {
                    type: data.type,
                    data: {
                        labels: data.labels,
                        datasets: datasets
                    },
                    options: {
                        responsive: true
                        //title: {
                        //    display: true,
                        //    text: data.title
                        //}
                    }
                };
                var myChart = new Chart(ctx, config);
                //window.myPie = new Chart(ctx, config);
            },
            error: function (rtnData) {
                alert('error' + rtnData);
            }
        });
    }

    function resetCanvas() {
        $('#chart').remove(); // this is my <canvas> element
        $('.grap-container').append('<canvas id="chart"><canvas>');
    }
});