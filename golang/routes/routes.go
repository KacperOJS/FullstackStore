// golang/routes/routes.go
package routes

import (
	"net/http"

	"github.com/gorilla/mux"
)

func SetupRoutes(r *mux.Router) {
	// Definiuj swoje trasy tutaj
	r.HandleFunc("/", HomeHandler).Methods("GET")
	r.HandleFunc("/api/products", ProductsHandler).Methods("GET")
	// Dodaj więcej tras według potrzeb
}

// Przykładowe handlery (przenieś je do oddzielnego pakietu w rzeczywistym projekcie)
func HomeHandler(w http.ResponseWriter, r *http.Request) {
	w.Write([]byte("Witaj w sklepie!"))
}

func ProductsHandler(w http.ResponseWriter, r *http.Request) {
	w.Write([]byte("Lista produktów"))
}
