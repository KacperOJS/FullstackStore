package main

import (
	"log"
	"net/http"

	"github.com/KacperOJS/golang/config"
	"github.com/KacperOJS/golang/pkg/database"
	"github.com/KacperOJS/golang/routes"
	"github.com/gorilla/mux"
)

func main() {
	// Wczytaj konfigurację
	cfg, err := config.Load()
	if err != nil {
		log.Fatalf("Błąd wczytywania konfiguracji: %v", err)
	}

	// Inicjalizuj połączenie z bazą danych
	db, err := database.InitDB()
	if err != nil {
		log.Fatalf("Błąd inicjalizacji bazy danych: %v", err)
	}
	defer db.Close()

	// Inicjalizuj router
	r := mux.NewRouter()

	// Ustaw trasy
	routes.SetupRoutes(r, db)

	// Utwórz serwer HTTP
	srv := &http.Server{
		Addr:    ":" + cfg.Port,
		Handler: r,
	}

	// Uruchom serwer
	log.Printf("Serwer nasłuchuje na porcie %s", cfg.Port)
	if err := srv.ListenAndServe(); err != nil && err != http.ErrServerClosed {
		log.Fatalf("Błąd uruchamiania serwera: %v", err)
	}
}
