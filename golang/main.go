package main

import (
	"bufio"
	"fmt"
	"os"
	"os/exec"

	"github.com/junior2pp/MaquinaTicket"
)

func main() {
	var price, opcion, moneda int
	fmt.Println("Ingrese el Precio del Ticket")
	fmt.Scan(&price)
	m := new(maquina.Ticket)
	m.Init(price)
	limpiarconsola()
	for {
		Menu()
		fmt.Println("Inserte Una Opcion")
		fmt.Scan(&opcion)
		switch opcion {
		case 1:
			fmt.Println("Inserte Moneda: ")
			fmt.Scan(&moneda)
			m.SetBalance(moneda)
			fmt.Println("Moneda Agregada Correctamente ok")
			pausa()
		case 2:
			fmt.Println("PRECIO --> ", m.GetPrecio())
			pausa()
		case 3:
			fmt.Println("BALANCE --> ", m.GetBalance())
			pausa()
		case 4:
			m.ImprimirTicket()
			pausa()
		case 5:
			fmt.Println(m.VaciarMaquina())
			pausa()
		case 6:
			precio, balance, total, contador := m.GetMaquinaInfo()
			fmt.Println("Vendidos --->", contador)
			fmt.Println("Total ------>", total)
			fmt.Println("Balance ---->", balance)
			fmt.Println("Precio ----->", precio)
			pausa()
		case 7:
			os.Exit(0)
		default:
			fmt.Println("Fuera de Rango (1 y 7)")
		}
		limpiarconsola()
	}
}
func Menu() {

	fmt.Println("1.Insertar Moneda")
	fmt.Println("2.Obtener Precio")
	fmt.Println("3.Obtener Balance")
	fmt.Println("4.Imprimir Ticket")
	fmt.Println("5.Vaciar Maquina")
	fmt.Println("6.Informacion de la Maquina")
	fmt.Println("7.Salir")
}
func limpiarconsola() {
	c := exec.Command("clear")
	c.Stdout = os.Stdout
	c.Run()
}
func pausa() {
	bufio.NewReader(os.Stdin).ReadBytes('\n')
}
