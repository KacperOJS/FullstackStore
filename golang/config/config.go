package config

import (
	"os"
	"strconv"
)

type Config struct {
	Port       string
	DBHost     string
	DBPort     int
	DBUser     string
	DBPassword string
	DBName     string
}

func Load() (*Config, error) {
	dbPort, _ := strconv.Atoi(os.Getenv("DB_PORT"))
	return &Config{
		Port:       os.Getenv("PORT"),
		DBHost:     os.Getenv("DB_HOST"),
		DBPort:     dbPort,
		DBUser:     os.Getenv("DB_USER"),
		DBPassword: os.Getenv("DB_PASSWORD"),
		DBName:     os.Getenv("DB_NAME"),
	}, nil
}
