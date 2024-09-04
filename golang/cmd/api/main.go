package main

import (
	"database/sql"
	"fmt"
	"log"
	"net/http"

	_ "github.com/go-sql-driver/mysql"
	"github.com/gorilla/mux"
)

const (
	host     = "localhost"
	port     = 3306
	user     = "root"
	password = ""
	dbname   = "sneakshop"
)

func main() {
	// Format connection string: username:password@tcp(host:port)/dbname
	connString := fmt.Sprintf("%s:%s@tcp(%s:%d)/%s", user, password, host, port, dbname)

	// Open a connection to the database
	db, err := sql.Open("mysql", connString)
	if err != nil {
		log.Fatalf("Error opening connection: %v", err)
	}
	defer db.Close()

	// Test the connection
	err = db.Ping()
	if err != nil {
		log.Fatalf("Error pinging database: %v", err)
	}
	fmt.Println("Connected to MySQL successfully!")

	// Inicjalizuj router
	r := mux.NewRouter()

	// Ustaw trasy
	r.HandleFunc("/", homeHandler).Methods("GET")
	r.HandleFunc("/customers", customersHandler(db)).Methods("GET")

	// Utwórz serwer HTTP
	srv := &http.Server{
		Addr:    ":8080",
		Handler: r,
	}

	// Uruchom serwer
	log.Printf("Serwer nasłuchuje na porcie 8080")
	if err := srv.ListenAndServe(); err != nil && err != http.ErrServerClosed {
		log.Fatalf("Błąd uruchamiania serwera: %v", err)
	}
}

func homeHandler(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "Witaj w sklepie!")
}

func customersHandler(db *sql.DB) http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		fmt.Println("customersHandler")
		rows, err := db.Query("SELECT * FROM customers LIMIT 10")
		fmt.Println(rows, "rows")
		log.Println(rows, "rows")
		if err != nil {
			http.Error(w, fmt.Sprintf("Error executing query: %v", err), http.StatusInternalServerError)
			return
		}
		defer rows.Close()

		var customers string
		for rows.Next() {
			var id int
			var name string
			err := rows.Scan(&id, &name)
			if err != nil {
				http.Error(w, fmt.Sprintf("Error scanning row: %v", err), http.StatusInternalServerError)
				return
			}
			customers += fmt.Sprintf("ID: %d, Name: %s\n", id, name)
		}

		fmt.Fprintf(w, customers)
	}
}
