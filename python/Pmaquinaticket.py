"""
  AUTOR=LUIS ALFREDO SUAREZ LITARDO
  2017-06-03
  MAQUINA DE TICKETS
  TELEMATICA 4TO MODULO
"""

from MaquinaTicket import MaquinaTicket
import os
import sys


def Menu():
    print "1. Insertar Moneda"
    print "2. Obtener Precio"
    print "3. Obtener Balance"
    print "4. Imprimir Ticket"
    print "5. Vaciar Maquina"
    print "6. Obtener Total y Cantidad de Tickets Vendidos"
    print "7. Salir"
    return


while True:
    try:
        os.system('cls||clear')
        costo = int(input("Inserte Costo del Ticket(init):"))
        if costo > 0:
            break
        else:
            raw_input("Inserte Moneda Mayor a 0")
    except Exception as e:
        print e
        raw_input("Presione Una tecla Para Continuar")

#CRECION DEL OBJETO
objeto = MaquinaTicket(costo)
#limpiar la consola
os.system('cls||clear')

#DICCIONARIO DE acciones
acciones = {'1': objeto.InsertarMoneda, '2': objeto.getPrecio, '3':objeto.getBalance,'4':objeto.ImprimirTicket,
            '5':objeto.VaciarMaquina,'6':objeto.getTotal}

while True:
        Menu()
        opcion = raw_input("Inserte una Opcion: ")
        if opcion == "7":
            sys.exit(0)

        if opcion == "1":
                moneda = int(input("---Inserte Una Moneda: "))
                resultado = acciones[opcion](moneda)
                print "---Moneda Agregada Correctamente"
        else:
            if opcion == "6":
                   total , cantidad = acciones[opcion]()
                   print "Tickets Vendidos = %d --> Total = %d " % (cantidad,total)
            else:
                try:
                    resultado = acciones[opcion]()
                    print resultado
                except Exception as e:
                    print "Ingrese una opcion entre 1 y 7"
                    print e


        raw_input("Presione una tecla para continuar.......")
        os.system('cls||clear')
