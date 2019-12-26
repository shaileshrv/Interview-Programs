
var size = 23;

/*
for (var i = 0; i <= size ; i++) {
	var str = "";
	for (var j = i; j < size; j++) {
		str +=" ";
	}
	for (var j = 0; j < i; j++) {
		str +="* ";
	}
	console.log(str);
}
*/

/*
for (var i = 0; i < size; i++) {
	var str = "";
	for (var j = 0; j < size; j++) {
		if((i==0||i==size-1)||(j==0||j==size-1)){
			str +="* ";
		}
		else {
			str	+="  ";
		}
	}
	console.log(str);
}
*/

for (var i = 0; i < size; i++) {
	var str ="";
	for (var j = 0; j < size; j++) {
		if(i==j||j==size-i-1){
			str+="* ";
		}
		else if((i==0||i==size-1)||(j==0||j==size-1)){
			str +="* ";
		}
		else if(i==parseInt(size/2)||j==parseInt(size/2)){
			str +="* ";
		}
		else{
			str+="  ";
		}
	}
	console.log(str);
}