yas = int(input("Yaşınızı giriniz: "))
if yas<40:
    mezuniyet = input("Üniversite mezunumusunuz? (E/H)")
    surucu_belgesi = input("Sürücü belgeniz var mı? (E/H)")
if mezuniyet=="E" and surucu_belgesi=="E":
        print("Tebrikler işe alındınız")
else:
        print("İşe alınmadınız")
