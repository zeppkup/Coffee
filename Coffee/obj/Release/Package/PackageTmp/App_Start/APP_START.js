var app = angular.module('POST_APP', []);

app.controller('INDEX_CTRL', function ($scope, $http) {
	$scope.send_data = function (func,item) {
		var request = $http({
			method: "post",
			url: "../Home/GETMENU",
			data: {
				FUNC: func,
				data: JSON.stringify(item)
			}
			//headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
		});
		return request
	}
	$scope.load = function () {
		$scope.coffee_menu = {}
		$scope.coffee_order_main_detail = {}
		$scope.list_coffee_order_main_detail = []
		$scope.coffee_order_main_detail_option = {}
		$scope.list_coffee_order_main_detail_option = []
		$scope.coffee_order = {};
		$scope.list_coffee_order = [];
		var send = $scope.send_data('1')
		send.then(function (datas) {
			$scope.data = datas.data
			var len_listpaid = $scope.data.L_coffee_order_main.length;
			for (i = 0; i < len_listpaid; i++) {
				$scope.data.L_coffee_order_main[i].DATE_ORDER = $scope.con_to_date($scope.CHANGE_FORMATDATE_typedate($scope.data.L_coffee_order_main[i].DATE_ORDER));
			}
		})
	}
	$scope.load();

	$scope.save_menu = function () {
		let temp = {
			coffee_menu:$scope.coffee_menu
		}
		var send = $scope.send_data('2', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.coffee_menu = {}
			$scope.load ()
		})
	}
	$scope.del_menu = function (item) {
		$scope.coffee_menu = $scope.data.L_coffee_menu[item];
		$scope.coffee_menu.NAME_COFFEE = null;
		let temp = {
			coffee_menu:$scope.coffee_menu
		}
		var send = $scope.send_data('2', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.coffee_menu = {}
			$scope.load()
		})
	}
	$scope.edit_menu = function (item) {
		$scope.coffee_menu = angular.copy($scope.data.L_coffee_menu[item]);
	}
	$scope.cance_save_menu = function () {
		$scope.coffee_menu = {};
	}
	$scope.fil_price1 = function () {
		if ($scope.coffee_order.NAME_COFFEE != null && $scope.coffee_order.NAME_DETAIL != null) {
			let temp = $scope.data.L_coffee_menu.filter(x => x.NAME_COFFEE == $scope.coffee_order.NAME_COFFEE)
			$scope.coffee_order.PRICE = $scope.coffee_order.NAME_DETAIL != 'ร้อน' ? temp[0].PREICE_COFFEE_COOL : temp[0].PREICE_COFFEE_HOT;
		}
	}
	//$scope.add_order1 = () => {
	//	if ($scope.coffee_order.edit != null) {
	//		$scope.list_coffee_order[$scope.coffee_order.edit] = angular.copy($scope.coffee_order);
	//	} else {
	//		$scope.list_coffee_order.push(angular.copy($scope.coffee_order));

	//	}
	//	$scope.clear_order()
	//}
	//$scope.del_order1 = function (index) {
	//	$scope.list_coffee_order.splice(index, 1)
	//}


	$scope.add_order1 = function () {
		let temp = {
			coffee_order: $scope.coffee_order
		}
		var send = $scope.send_data('4', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.coffee_order = {}
			$scope.load()
		})
	}
	$scope.del_order1 = function (item) {
		$scope.coffee_order = $scope.data.L_coffee_order[item];
		$scope.coffee_order.NAME_COFFEE = null;
		let temp = {
			coffee_order: $scope.coffee_order
		}
		var send = $scope.send_data('4', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.coffee_order = {}
			$scope.load()
		})
	}
	$scope.edit_order1 = function (index) {
		$scope.coffee_order = angular.copy($scope.data.L_coffee_order[index])
		$scope.coffee_order.edit = index
	}
	$scope.clear_order1 = function (index) {
		$scope.coffee_order = {};
	}

	$scope.fil_price = function () {
		if ($scope.coffee_order_main_detail.NAME_COFFEE != null && $scope.coffee_order_main_detail.NAME_DETAIL != null) {
			let temp = $scope.data.L_coffee_menu.filter(x => x.NAME_COFFEE == $scope.coffee_order_main_detail.NAME_COFFEE)
			$scope.coffee_order_main_detail.PRICE = $scope.coffee_order_main_detail.NAME_DETAIL != 'ร้อน' ? temp[0].PREICE_COFFEE_COOL : temp[0].PREICE_COFFEE_HOT;
			$scope.coffee_order_main_detail.PRICE = $scope.coffee_order_main_detail.NUMBER != undefined && $scope.coffee_order_main_detail.NUMBER != '' ? $scope.coffee_order_main_detail.NUMBER * $scope.coffee_order_main_detail.PRICE : $scope.coffee_order_main_detail.PRICE
		}
	}	

	$scope.add_order = () => {
		$scope.coffee_order_main_detail.NUMBER = $scope.coffee_order_main_detail.NUMBER || 1
		if ($scope.coffee_order_main_detail.edit != null) {
			$scope.list_coffee_order_main_detail[$scope.coffee_order_main_detail.edit] = angular.copy($scope.coffee_order_main_detail);
		} else {
			$scope.coffee_order_main_detail.ID = $scope.list_coffee_order_main_detail.length
			$scope.list_coffee_order_main_detail.push(angular.copy($scope.coffee_order_main_detail));

		}
		$scope.clear_order()
	}
	$scope.del_order = function (index) {
		$scope.list_coffee_order_main_detail.splice(index, 1)
	}
	$scope.edit_order = function (index) {
		$scope.coffee_order_main_detail = angular.copy($scope.list_coffee_order_main_detail[index])
		$scope.coffee_order_main_detail.edit = index
	}
	$scope.clear_order = function (index) {
		$scope.coffee_order_main_detail = {};
	}

	$scope.fil_price_detail = function () {
		if ($scope.coffee_order_main_detail_option.NAME_OPTION != null) {
			let temp = $scope.data.L_coffee_detail.filter(x => x.OPTION_DETAIL == $scope.coffee_order_main_detail_option.NAME_OPTION)
			$scope.coffee_order_main_detail_option.PRICE_OPTION = temp[0].OPTION_PRICE;
			$scope.coffee_order_main_detail_option.PRICE_OPTION = $scope.coffee_order_main_detail_option.NUMBER != undefined && $scope.coffee_order_main_detail_option.NUMBER != '' ? $scope.coffee_order_main_detail_option.NUMBER * $scope.coffee_order_main_detail_option.PRICE_OPTION : $scope.coffee_order_main_detail_option.PRICE_OPTION
		}
	}
	$scope.setindex_order_detail = function (index) {
		$scope.index_coffee = index;
		//$scope.name_coffee = $scope.list_coffee_order_main_detail[index].NAME_COFFEE;
		$scope.fk_order = $scope.list_coffee_order_main_detail[index].ID;
		$scope.set_Slist_lot();
	}
	$scope.cancel_index_order_detail= function () {
		$scope.index_coffee = null;
		$scope.fk_order = null;
		$scope.clear_order_detail()
	}


	$scope.Add_order_detail = function () {
		$scope.coffee_order_main_detail_option.NUMBER = $scope.coffee_order_main_detail_option.NUMBER || 1
		$scope.coffee_order_main_detail_option.FK_ID = $scope.list_coffee_order_main_detail[$scope.index_coffee].ID == undefined ? $scope.index_coffee : $scope.list_coffee_order_main_detail[$scope.index_coffee].ID;
		//$scope.coffee_order_main_detail_option.NAME_COOFFEE = $scope.name_coffee;
		$scope.list_coffee_order_main_detail_option.push($scope.coffee_order_main_detail_option);
		$scope.coffee_order_main_detail_option = {};
	}
	$scope.del_order_detail = function (index) {

		$scope.list_coffee_order_main_detail_option.splice(index, 1);
	}
	$scope.clear_order_detail = function () {
		$scope.coffee_order_main_detail_option = {};
	}


	$scope.cancel_order_list = function () {
		$scope.coffee_order_main = {}
		$scope.list_coffee_order_main_detail = [];
		$scope.list_coffee_order_main_detail_option = []
	}
	$scope.edit_order_list = function (index) {
		$scope.coffee_order_main = angular.copy($scope.data.L_coffee_order_main[index])
		$scope.list_coffee_order_main_detail = $scope.data.L_coffee_order_main_detail.filter(x => x.FK_ID == $scope.coffee_order_main.ID);
		$scope.list_coffee_order_main_detail_option = $scope.data.L_coffee_order_main_detail_option.filter(x => x.FK_MAIN_ID == $scope.coffee_order_main.ID)
	}
	$scope.save_order_list = function () {
		$scope.coffee_order_main.DATE_ORDER = null;
		let temp = {
			coffee_order_main: $scope.coffee_order_main,
			L_coffee_order_main_detail: $scope.list_coffee_order_main_detail,
			L_coffee_order_main_detail_option: $scope.list_coffee_order_main_detail_option,
		}
		var send = $scope.send_data('3', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.coffee_menu = {}
			$scope.load()
		})
	}
	$scope.del_order_list = function (item) {
		$scope.coffee_order_main = $scope.data.L_coffee_order_main[item];
		$scope.coffee_order_main.NAME_MENU = null;
		$scope.coffee_order_main.DATE_ORDER = null;
		let temp = {
			coffee_order_main: $scope.coffee_order_main,
			L_coffee_order_main_detail: $scope.list_coffee_order_main_detail,
			L_coffee_order_main_detail_option: $scope.list_coffee_order_main_detail_option,
		}
		var send = $scope.send_data('3', temp)
		send.then(function (datas) {
			//$scope.data = datas.data
			//$scope.cancel_order_list()

			$scope.cancel_order_list()
			$scope.load()
		})
	}


	$scope.CHANGE_FORMATDATE_typedate = function (DATE_CHANGE) {
		var dateString = DATE_CHANGE.substr(6);
		var currentTime = new Date(parseInt(dateString));
		var month = currentTime.getMonth() + 1;
		var day = currentTime.getDate();
		var year = currentTime.getFullYear();
		return DATE_CHANGE = month + "/" + day + "/" + year;
	}
	$scope.con_to_date = function (dateString) {
		try {
			var dateArray = new Date(dateString);
		}
		catch (err) {
		}
		return dateArray;
	};


})