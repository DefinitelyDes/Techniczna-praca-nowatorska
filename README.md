5.11.2023
changelog: 
stworzenie 2 typow przeciwnikow, nacierajacy oraz uciekajacy, kiedy gracz bedzie w poblizu
https://youtu.be/oXJBGnOJ45w

![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/3bcf4e08-f934-4ab2-9246-93d07cfda086)

generator losowych poziomow (na te chwile sa 4 rozne roomy + 1 boss room) 
![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/5d2190d8-746c-4ff2-b42a-a5ea21223125)
![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/9985dd43-e089-43bc-ba1d-012c4ce8f5e0)

Enemies(WIP)(boss)

![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/de52ae1a-75c1-4022-a7c2-d22ae2e6f493)
![Bartek borsuk](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/6cea2af0-5a8f-4ffe-aedc-ac365331a479)

sprity stworzen
![Sprite-0001](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/233205b1-300b-4cbb-8463-3a81b05d9f51)
![Sprite-0006](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/9cf5bcf1-a951-49ec-9f1e-410b4b443b1e)
![Combat-sheet](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/ceaee230-4ad0-493d-aed0-84cdc9012355)


sprity terenu
![ziemia-sheet](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/611c46d3-4722-4959-80fd-c96238622a8f)
![Ziemia 1 11 2024](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/55575317-6a90-4db5-8694-7bfb09499fb9)
![Ziemia 1 11 2023](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/d81f9950-05d9-4181-bec7-72c44165d62d)
![Ziemia 1 11 2023 2](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/a2e6f059-1d1f-4bfe-9f31-5a1613a906d9)
![ziemia-sheet](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/8e09cc13-def4-40d1-84bc-a29eab56c107)
![Ziemia 1 11 2023 345](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/f05cbd0b-1fc2-452f-9669-6358ffb234b3)
![Ziemia 1 11 2023 34](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/afe21911-9a69-4294-a0f0-ecd9b7fd003d)
![Ziemia 1 11 2023 3](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/736558fe-e2be-405c-b8f4-db7cd39e1c97)




Temat pracy - Gra rogue like z wykorzytaniem AI

Poprzednim razem miałem zaimplementowane podstawowe elementy rogue like tj generowanie losowe map, potwory etc 

Aktualnie jedynie napisałem prosta gre w ktorej postac porusza sie po kwadratowej mapie (brak assetow) 
Sam pomysl przez koniecznosc rozpoczecia od nowa trochę evoluowal, chcialbym zrobic gre z "perspektywy" psa, ktory wraca do domu, z perspektywy gry beda to losowe plansze (aka blakanie sie), ktore bedziemy przechodzic az trafimy do domu
Potworami chce, aby byly rzeczy codzienne, tylko karytakuralne(chojrak tchorzliwy pies)
 np potwor ktory probuje nas zlapac(hycel)
 ![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/e85c0c3f-4b3b-4c65-ab8d-816a87b7828b)

 halasujace stwory, ktore na nas szarżuja, odrzucaja i zadaja obrazenia.(tu moze byc nawet dzik, jako element map lesnych np)
 ![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/4d55c9bb-5f4a-4092-ba3d-9d1817b23a18)

 Swiatla ktore ograniczaja wizje etc
 ![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/0f050e07-0ace-4f56-95f6-9b5f5a66a1e2)

Nasza postac chce, aby zdobywała losowe przedmioty, które beda zapewniały statystyki - przedmioty tez beda codziennego uzytku, np megafon przez co ataki dystansowe beda mialy wiekszy zasieg. koszulka, ktora bedzie dawala wiecej zycia, czy smycz, ktora bedzie nam zwiekszala szybkosc poruszania się

Nie wiem na ile uda mi sie zaimplementowac wszystkie elementy, aktualnie staram sie wybrac jeden typ graficzny by stworzyc wstepne assety, kolejnosc nad jaka bede wprowadzal nowe rzeczy to Generowanie map -> potwory -> roznorodnosc atakow -> przedmioty
Przedmioty same w sobie nie beda problemem, chyba ze beda mialy ze soba oddzialywanie, co chcialbym zrobic jesli czas pozwoli

![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/d3010c78-d731-488c-8c1d-bf74e074cfc1)

![image](https://github.com/DefinitelyDes/Techniczna-praca-nowatorska/assets/105553536/fe799081-c461-4463-9ad0-da182c79e9e4)
Przykladowy wyglad postaci ktora mielibysmy grac, jako dodatkowy cel, chcialbym, aby jej wyglad zmienial sie z kolejnymi przedmiotami ktore bedziemy zdobywac
