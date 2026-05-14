s_pares = s_impares = 0

while True:
    num = int(input("Ingrese un número (0 para salir): "))

    if num == 0: break
    if num < 0: 
        print("Número inválido\n")
        continue
    if(num%2 == 0): s_pares += num
    else: s_impares += num

print("\nSuma de pares: ",s_pares)
print("Suma de impares: ",s_impares)

