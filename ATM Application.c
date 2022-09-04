#include<stdio.h>
int main(){
	int bakiye,tutar,islem;
	bakiye = 0;
	printf("Bir islem seciniz\n");
	printf("1 - Para Yatirma\n");
	printf("2 - Para Cekme\n");
	printf("3 - Bakiyeyi Goster\n");
	scanf("%d",&islem);
	switch(islem){
		case 1:
			bakiye = 0;
			printf("Yatirmak istediginiz miktari giriniz: ");
			scanf("%d",&tutar);
			bakiye = bakiye + tutar;
			printf("Bakiyeniz: %d\n",bakiye);
			break;
		case 2:
			bakiye = 0;
			printf("Cekmek istediginiz miktari giriniz: ");
			scanf("%d",&tutar);
			if(tutar > bakiye){
				printf("Yetersiz Bakiye.\n");
				printf("Toplam Bakiyeniz: %d",bakiye);
			}
			else{
				bakiye = bakiye - tutar;
				printf("Kalan Bakiyeniz: %d",bakiye);
			}
			break;
		case 3:
			printf("Bakiyeniz: %d\n",bakiye);
			break;
		default:
			printf("Belirlenemeyen islem");
			break;
	}
	return 0;
}
