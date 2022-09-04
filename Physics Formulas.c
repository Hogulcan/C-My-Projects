#include<stdio.h>
int main(){
	int islem,volt,amper,resistance,load_power,time,flow,distance_traveled,time_elapsed;
	printf("1 - Calculate Resistance\n");
	printf("2 - Calculate Flow\n");
	printf("3 - Calculate Speed\n");
	scanf("%d",&islem);
	switch(islem){
		case 1:
			printf("Enter Volt: \n");
			scanf("%d",&volt);
			printf("Enter Amper: \n");
			scanf("%d",&amper);
			printf("Resistance: %d",volt / amper);
			break;
		case 2:
			printf("Enter Load Power: \n");
			scanf("%d",&load_power);
			printf("Enter Time(second): \n");
			scanf("%d",&time);
			printf("Flow: %d",load_power / time);
			break;
		case 3:
			printf("Distance Traveled: \n");
			scanf("%d",&distance_traveled);
			printf("Time Elapsed: \n");
			scanf("%d",&time_elapsed);
			printf("Speed: %d",distance_traveled / time_elapsed);
			break;
		default:
			printf("Don't know process");
			break;
	}
	return 0;
}
