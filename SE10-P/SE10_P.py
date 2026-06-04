from Cajero import Cajero
c = Cajero()

continuar="s"

while(continuar =="s"):
    print(" ------------------------------------------------")
    print("|        BIENVENIDOS AL SISTEMA DE CAJERO        |")
    print(" ------------------------------------------------\n")
    print("1. Consultar saldo")
    print("2. Depositar dinero")
    print("3. Retirar dinero")
    print("4. Salir\n")

    while(True):
        opcion = int(input("Ingrese una opción: "))

        if opcion in(1,2,3,4):
            break
        else:
            print("Error. Opción no valida.\n")

    match opcion:
        case 1: print("\nSaldo disponible S/ ", c.Consultar())
        case 2: 
            while(True):
                try:
                    monto = float(input("\nIngrese el monto a depositar S/ "))
                    if(monto >0):
                        c.Depositar(monto)
                        break
                    else: print("Error. Solo se permiten positivos.\n")
                except ValueError:
                    print("Error solo se permiten números válidos.\n")
            
            
        case 3:print()
        case 4:quit()

    while(True):
        continar = input("\n¿Desea continuar? presione [S] o para salir [N]: ").lower()
        if continar in ("s","n"):
            break
        else: 
            print("Error. Solo permite S o N.")
            
