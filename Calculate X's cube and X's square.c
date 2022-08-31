#include<stdio.h>
int main(){
	int islem,x;
	printf("1 - Calculate X's square\n");
	printf("2 - Calculate X's cube\n");
	scanf("%d",&islem);
	if(islem == 1){
		printf("Enter X: \n");
		scanf("%d",&x);
		printf("X's square: %d",x * x);
	}
	if(islem == 2){
		printf("Enter X: \n");
		scanf("%d",&x);
		printf("X's cube: %d",x * x * x);
	}
	return 0;
}	
