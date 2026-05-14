cantidad = int(input("Ingrese la cantidad de números: "))

pares = impares = ceros = 0

print()
for i in range(0, cantidad):
    num = int(input(f"Ingrese el número {i+1}: "))

    if(num == 0): ceros+=1
    elif num%2 == 0: pares+=1
    else: impares +=1

print("\nCantidad de ceros: ",ceros)
print("Cantidad de pares: ",pares)
print("Cantidad de impares: ",impares)
        