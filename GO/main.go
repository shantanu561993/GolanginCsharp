package main
import "fmt"
import "C"
import "strings"

func main() {
}

//PrintHello :
//export PrintHello
func PrintHello() {
    fmt.Println("Hello From Golang")
}

//Sum :
//export Sum
func Sum(a, b int) int {
    return a + b
}

//stringtest :
//export stringtest
func stringtest(name *C.char) {
	s := strings.Fields(C.GoString(name))
    fmt.Println(s)
}
