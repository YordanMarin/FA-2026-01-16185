def suma(num1, num2)->None:
    print("La suma es: ",num1+num2)

def resta(num1, num2)->None:
    print("La suma es: ",num1-num2)

def multi(num1, num2)->None:
    print("La suma es: ",num1*num2)

def divi(num1, num2)->None:
    if num2!=0:
        print("La suma es: ",num1//num2)
    else: 
        print("No se puede dividir entre 0.")

while(True):

    print("BIENVENIDO AL SISTEMA DE CALCULADORA BÁSICA\n")
    print("1. Suma")
    print("2. Resta")
    print("3. Multiplicación")
    print("4. División")
    print("5. Salir\n")

    opc = int(input("Ingrese una opción: "))

    if opc >=1 and opc <=4:
        num1 = int(input("Ingrese número 1: "))
        num2 = int(input("Ingrese número 2: "))

    match opc:
        case 1: suma(num1, num2)
        case 2: resta(num1, num2)
        case 3: multi(num1, num2)
        case 4: divi(num1, num2)
        case 5:exit()
        case _: print("\nOpción no válida.!")

    continuar = input("\n¿Desea continuar? (presione [y]): ")

    if(continuar != "y"): break
    