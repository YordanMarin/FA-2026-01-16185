edad = input(int("Ingrese la edad: "))

if (edad >= 18):
    print("Puede votar")
    if(edad >= 25):
        print("Pueder ser politico")
        if(edad >=40):
            print("Puede ser empresario")
else: print("No puede votar ni ser politico");