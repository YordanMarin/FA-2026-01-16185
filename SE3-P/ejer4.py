import math

num = float(input("Ingrese un número decimal: "))

print(f"\nRaiz cuadrada: {math.sqrt(num)}")
print(f"Redondeado: {round(num,0)}")
print(f"Elevado al cubo: {math.pow(num, 3)}")
print(f"Raiz cubica: {num ** (1/3)}")