/*========================================
	Ajax Scripts for Async Requisitions
========================================*/

//==========================================================
//Function to put the requested page into section contentPage 
function requestPage(url){
	//request still not started
	let ajax = new XMLHttpRequest();

	//estabilished connection with server
	ajax.open('GET', url);

	//checking every state of ajax, to treat the return type
	ajax.onreadystatechange = () => {
		if(ajax.readyState == 4 && ajax.status == 200){
			console.log(ajax.responseText);
			document.getElementById('contentPage').innerHTML = ajax.responseText;
		}
		else if (ajax.readyState == 4 && ajax.status == 404){
			requestPage('Pages/error404.php');
		}
	}

	//Send the request
	ajax.send();
}