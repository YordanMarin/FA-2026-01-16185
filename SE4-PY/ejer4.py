print("--- SISTEMA DE CALCULO DE ÁREAS ---\n")

print("Menú de opciones: ")
print("1. Cuadrado")
print("2. Rectángulo")
print("3. Triángulo")
print("4. Circulo\n")

opc = int(input("Ingrese una opción: "))

match opc:

    case 1:
        lc = int(input("\nIngrese lado: "))
        area = lc * lc
        print(f"\nÁrea del cuadrado: {area}")
    case 2:
        br = int(input("\nIngrese base: "))
        ar= int(input("Ingrese altura: "))
        area = br * ar
        print(f"\nÁrea del rectángulo: {area}")
    case 3:
        bt = int(input("\nIngrese base: "))
        at= int(input("Ingrese altura: "))
        area = bt * at
        print(f"\nÁrea del triángulo: {area}")
    case 4:
        import math
        rc = int(input("\nIngrese radio: "))
        area = math.pi * math.pow(rc, 2);
        print(f"\nÁrea del circulo: {area}");
    case _:print("\nOpción incorrecta!");