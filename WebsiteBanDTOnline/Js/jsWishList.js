$(document).ready(function () {
    $('body').on('click', '.btnAddToWishList', function (e) {
        e.preventDefault();
        var id = $(this).data('id');

        $.ajax({
            url: '/wishlist/addtowishlist',
            type: 'POST',
            data: { id: id},
            success: function (rs) {
                if (rs.success) {
                }
            }
        });
    });



    $('body').on('click', '.btnDeleteAllList', function (e) {
        e.preventDefault();
        var conf = confirm('Bạn muốn xóa hết sản phẩm trong danh sách ước?');
        if (conf == true) {
                $.ajax({
                    url: '/wishlist/DeleteAll',
                    type: 'POST',
                    success: function (rs) {
                        if (rs.success) {
                            LoadWishList();
                        }
                    }
                });
            location.reload();
        }

    });


    $('body').on('click', '.btnDeleteList', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var conf = confirm(" Bạn có chắc chắn xóa không ?");
        if (conf === true) {
            $.ajax({
                url: "/wishlist/delete",
                type: 'POST',
                data: { id: id },
                success: function (rs) {
                    if (rs.success) {
                        $('#trow_' + id).remove();
                        location.reload();
                    }
                }
            });
        }
        location.reload();
    });
});



function LoadWishList() {
    $.ajax({
        url: '/wishlist/Partical_Item_WishList',
        type: 'GET',
        success: function (rs) {
            if (rs.success) {
                $('#load_data').html(rs);
            }
        }
    });
}
