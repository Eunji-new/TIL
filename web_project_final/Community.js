function myfunction() {
	var name = prompt("이름을 입력하세요", "");
	if(name == null) { alert('응모를 포기하셨습니다.') } 
	else if(name == "") { alert('이름 입력 후 응모해주세요'); myfunction(); } 
	else { alert(name+'님 응모되셨습니다.'); }
}

function myfunction2() {
	var num = prompt("충전금액을 입력하세요.", "");
	if(num == null) { alert('충전을 취소합니다.') } 
	else if(num == "") { alert('금액 입력 후 충전 가능합니다.'); myfunction2(); }
	else if(num<50000) { alert('50000원 이상 충전 시에만 이벤트 참여 가능합니다.');}
	else { alert('충전이 성공정으로 완료되었습니다! \n매장을 방문하여 상품을 수령해주세요.'); }
}

function myfunction3() {
	var name = prompt("이름을 입력하세요.","");
	if(name == null) { alert('당첨자 조회를 취소합니다') } 
	else if(name == "") { alert('이름 입력 후 조회 가능합니다'); myfunction3(); } 
	else {
		var num = Math.floor(Math.random()*10);
		if(num<8){ alert('당첨자 명단에 없습니다. \n다음 이벤트에 도전해주세요!');}
		else{ var phone = prompt(name+"님 당첨을 축하드립니다!! \n전화번호를 남겨주시면 당첨일로부터 7일 이내 개별적으로 연락드리겠습니다.")}
	}
}

function myfunction4() {
	var name = prompt("비공개 글입니다 \n비밀번호를 입력하세요", "");
	if(name == null) { alert('취소합니다') } 
	else if(name == "") { alert('비밀번호를 입력해주세요'); myfunction4(); } 
	else { alert('비밀번호가 올바르지 않습니다.'); }
}

function menuu() {
		document.getElementById("menu").style.visibility='visible';
		document.getElementById("menu2").style.visibility='visible';
	}
	
function menuu2() {
	document.getElementById("menu").style.visibility='hidden';
	document.getElementById("menu2").style.visibility='hidden';
}