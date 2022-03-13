<meta charset="utf-8">
@*<link rel="stylesheet" type="text/css" href="~/css/fontawesome-all.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">*@
<script src="~/Scripts/angular.js"></script>
<script src="~/Scripts/angular-animate.js"></script>
<script src="~/Scripts/angular-aria.js"></script>
<script src="~/Scripts/ng-file-upload.js"></script>
<script src="~/Scripts/angular-material.js"></script>


<script src="~/App_Start/APP_START.js"></script>
<script src="~/Scripts/sweetalert2.all.min.js"></script>

@*<link href="/Css/StyleSheet1.css" rel="stylesheet">
    <link href="/Css/MyStyle.css" rel="stylesheet">
    <link href="~/Css/FDA_ADV.css" rel="stylesheet" />*@


<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<script src="~/Scripts/bootstrap.min.js"></script>
<style>

    table, td, th {
        border: 1px solid gray;
    }
</style>
<body>
    <div ng-app="POST_APP" ng-controller="INDEX_CTRL">
        <div class="container">
            <h3>เมนู</h3>
            <table>
                <tr>
                    <th rowspan="2">
                        ลำดับ
                    </th>
                    <th rowspan="2">
                        รายการ
                    </th>
                    <th colspan="2">ราคา</th>
                    <th rowspan="2">
                        แก้ไข
                    </th>
                    <th rowspan="2">
                        ลบ
                    </th>

                </tr>
                <tr>
                    <td>ร้อน</td>
                    <td>เย็น</td>
                </tr>
                <tr ng-repeat="x in data.L_coffee_menu">
                    <td>{{$index +1 }}</td>
                    <td>{{x.NAME_COFFEE}}</td>
                    <td>{{x.PREICE_COFFEE_HOT}}</td>
                    <td>{{x.PREICE_COFFEE_COOL}}</td>
                    <td><input type="button" value="edit" ng-click="edit_menu($index)" /></td>
                    <td><input type="button" value="del" ng-click="del_menu($index)" /></td>
                </tr>
            </table>

            <fieldset>
                <strong>เพิ่มเมนู</strong><br />
                รายการ: <input typy="text" ng-model="coffee_menu.NAME_COFFEE" /><br />
                ราคาร้อน:<input typy="text" ng-model="coffee_menu.PREICE_COFFEE_HOT" /><br />
                ราคาเย็น:<input typy="text" ng-model="coffee_menu.PREICE_COFFEE_COOL" /><br />
                <input type="button" value="save" ng-click="save_menu()" />
                <input type="button" value="cancel" ng-click="cance_save_menu()" />
            </fieldset>
        </div>
        <hr />
        <div class="container">
            <h3>รายการเดียว</h3>
            <fieldset>
                <table>
                    
                    <tr>
                        <td >ลำดับ</td>
                        <td >เมนู</td>
                        <td >ประเภท</td>
                        <td >ราคา</td>
                        <td >แก้ไข</td>
                        <td >ยกเลิก</td>
                    </tr>

                    <tr ng-repeat="x in data.L_coffee_order">
                        <td>{{$index +1}}</td>
                        <td>{{x.NAME_COFFEE}}</td>
                        <td>{{x.NAME_DETAIL}}</td>
                        <td>{{x.PRICE}}</td>
                        <td><input type="button" value="edit" ng-click="edit_order1($index)" /></td>
                        <td><input type="button" value="del" ng-click="del_order1($index)" /></td>
                    </tr>
                </table>
                <strong>สั่งเมนู</strong><br />
                รายการ:
                <select ng-model="coffee_order.NAME_COFFEE" ng-change="fil_price1()">
                    <option ng-value="">เลือกรายการ</option>
                    <option ng-repeat="item in data.L_coffee_menu" ng-value="item.NAME_COFFEE">{{item.NAME_COFFEE}}</option>
                </select><br />
                ประเภท:
                <select ng-model="coffee_order.NAME_DETAIL" ng-change="fil_price1()">
                    <option ng-value="">เลือกรายการ</option>
                    <option ng-value="'ร้อน'">ร้อน</option>
                    <option ng-value="'เย็น'">เย็น</option>
                </select><br />
                ราคา: {{coffee_order.PRICE}}<br />
                <input type="button" value="add" ng-click="add_order1()" />
                <input type="button" value="cancel" ng-click="clear_order1()" />


            </fieldset>

        </div>
        <hr />


        <div class="container">
            <h3>หลายรายการ</h3>
            <table>
                <tr>
                    <th>
                        ลำดับ
                    </th>
                    <th>
                        รายการ
                    </th>
                    <th>
                        รายละเอียด
                    </th>
                    <th>
                        ราคารวม
                    </th>  
                    <th>
                        วันที่
                    </th>
                    <th>
                        ลบ
                    </th>

                </tr>

                <tr ng-repeat="x in data.L_coffee_order_main">
                    <td>{{$index +1 }}</td>
                    <td>{{x.NAME_MENU}}</td>
                    <td>
                        <table>
                            <tr>
                                <td>ชื่อรายการ</td>
                                <td>ประเภท</td>
                                <td>ราคา</td>
                                <td>จำนวน</td>
                                <td>option</td>
                            </tr>
                            <tr ng-repeat="item in data.L_coffee_order_main_detail" ng-if="item.FK_ID == x.ID && data.L_coffee_order_main_detail.length > 0">
                                <td>{{item.NAME_COFFEE}}</td>
                                <td>{{item.NAME_DETAIL}}</td>
                                <td>{{item.PRICE}}</td>
                                <td>{{item.NUMBER}}</td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>ชื่อoption</td>
                                            <td>จำนวน</td>
                                            <td>ราคา</td>
                                        </tr>
                                        <tr ng-repeat="item2 in data.L_coffee_order_main_detail_option" ng-if="(item2.FK_ID == item.ID) && data.L_coffee_order_main_detail_option.length > 0">
                                            <td>{{item2.NAME_OPTION}}</td>
                                            <td>{{item2.NUMBER}}</td>
                                            <td>{{item2.PRICE_OPTION}}</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>


                    </td>
                    <td>
                        {{x.TOTAL_PRICE}}
                    </td>         
                    <td>
                        {{x.DATE_ORDER | date:'d/M/yyyy'}}
                    </td>
                    @*<td><input type="button" value="edit" ng-click="edit_order_list($index)" /></td>*@
                    <td><input type="button" value="del" ng-click="del_order_list($index)" /></td>
                </tr>
            </table>

            <hr />
            <fieldset>

                <strong>สั่งเมนู</strong><br />
                ชื่อเมนู:<input typy="text" ng-model="coffee_order_main.NAME_MENU" ng-change="fil_price()" /><br />
                <strong>เลือกรายการ</strong><br />
                รายการ:
                <select ng-model="coffee_order_main_detail.NAME_COFFEE" ng-change="fil_price()">
                    <option ng-value="">เลือกรายการ</option>
                    <option ng-repeat="item in data.L_coffee_menu" ng-value="item.NAME_COFFEE">{{item.NAME_COFFEE}}</option>
                </select><br />
                ประเภท:
                <select ng-model="coffee_order_main_detail.NAME_DETAIL" ng-change="fil_price()">
                    <option ng-value="">เลือกรายการ</option>
                    <option ng-value="'ร้อน'">ร้อน</option>
                    <option ng-value="'เย็น'">เย็น</option>
                </select><br />
                จำนวน:<input typy="text" ng-model="coffee_order_main_detail.NUMBER" ng-change="fil_price()" /><br />
                ราคา:@*<input typy="text" ng-model="coffee_order_main_detail.PRICE" />*@ {{coffee_order_main_detail.PRICE}}<br />
                <input type="button" value="add" ng-click="add_order()" />
                <input type="button" value="cancel" ng-click="clear_order()" />
                <table>
                    <colgroup>
                        <col span="5" >
                        <col span="4" width="500">
                        <col  width="1000">
                        <col span="2" >
                    </colgroup>
                    <tr>
                        <td rowspan="2">ลำดับ</td>
                        <td rowspan="2">เมนู</td>
                        <td rowspan="2">ประเภท</td>
                        <td rowspan="2">ราคา</td>
                        <td rowspan="2">จำนวน</td>
                        <td colspan="4">รายละเอียดoption</td>
                        <td rowspan="2" >เพิ่มoption</td>
                        <td rowspan="2">แก้ไข</td>
                        <td rowspan="2">ยกเลิก</td>
                    </tr>
                    <tr>
                        <td>รายการ</td>
                        <td>จำนวน</td>
                        <td>ราคา</td>
                        <td>ลบ</td>
                    </tr>
                    <tr ng-repeat="x in list_coffee_order_main_detail">
                        <td>{{$index +1}}</td>
                        <td>{{x.NAME_COFFEE}}</td>
                        <td>{{x.NAME_DETAIL}}</td>
                        <td>{{x.PRICE}}</td>
                        <td>{{x.NUMBER}}</td>

                        <td colspan="4">
                            <center>
                                <div ng-repeat="item in list_coffee_order_main_detail_option" ng-if="(item.FK_ID == x.ID) && list_coffee_order_main_detail_option.length > 0" style="text-align:left;" class="row">
                                    <div class="col-lg-3">{{item.NAME_OPTION}}</div>
                                    <div class="col-lg-3">{{item.NUMBER}}</div>
                                    <div class="col-lg-3">{{item.PRICE_OPTION}}</div>
                                    <div class="col-lg-3"><input type="button" value="del_op" ng-click="del_order_detail($index)" /></div>
                                </div>
                            </center>
                        </td>
                        <td>
                            <div class="row">
                                <div class="col-lg-1"></div>
                                <div id="option{{$index}}" class="collapse">
                                    <fieldset>
                                        <strong>เพิ่ม option</strong><br />
                                        รายการ:
                                        <select ng-model="coffee_order_main_detail_option.NAME_OPTION" ng-change="fil_price_detail()">
                                            <option ng-value="">เลือรายการ</option>
                                            <option ng-repeat="item in data.L_coffee_detail" ng-value="item.OPTION_DETAIL">{{item.OPTION_DETAIL}}</option>
                                        </select><br />
                                        จำนวน:<input typy="text" ng-model="coffee_order_main_detail_option.NUMBER" ng-change="fil_price_detail()" /><br />
                                        ราคา:@*<input typy="text" ng-model="coffee_order_main_detail_option.PRICE_OPTION" />*@{{coffee_order_main_detail_option.PRICE_OPTION}}<br />
                                        <input type="button" value="add" ng-click="Add_order_detail()" />

                                        <input type="button" value="cancel" ng-click="clear_order_detail()" /><br />
                                        <input type="button" data-toggle="collapse" data-target="#option{{$index}}" value="ปิด" ng-click="cancel_index_order_detail($index)" />
                                    </fieldset>
                                    
                                </div>
                                <input type="button" data-toggle="collapse" data-target="#option{{$index}}" id="butt_op{{$index}}" value="เพิ่มรายละเอียด" ng-click="setindex_order_detail($index)" />

                            </div>
                        </td>
                        <td><input type="button" value="edit" ng-click="edit_order($index)" /></td>
                        <td><input type="button" value="del" ng-click="del_order($index)" /></td>
                    </tr>
                </table>
                <input type="button" value="save" ng-click="save_order_list()" />
                <input type="button" value="cancel" ng-click="cancel_order_list()" />
            </fieldset>
        </div>

    </div>
    <hr />
</body>

