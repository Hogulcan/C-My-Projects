#include<stdio.h>
int main(){
int number1,number2,process;
printf("Enter Number1: \n");
scanf("%d",&number1);
printf("Enter Number2: \n");
scanf("%d",&number2);
printf("You choose process: \n");
printf("1 -) + \n");
printf("2 -) - \n");
printf("3 - ) * \n");
printf("4 - ) / \n");
scanf("%d",&process);
switch(process){
	case 1:
		printf("Total: %d",number1 + number2);
		break;
	case 2:
		printf("Total: %d",number1 - number2);
		break;
	case 3:
		printf("Total: %d",number1 * number2);
		break;
	case 4:
		printf("Total: %d",number1 / number2);
		break;
	default:
		printf("Don't know process");
		break;
}
	return 0;
}
