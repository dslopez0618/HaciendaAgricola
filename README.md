# Hacienda Agrícola - Sistema de Gestión

Este repositorio contiene la implementación de un sistema de gestión para una hacienda agrícola, desarrollado para el parcial de [Nombre de la Asignatura]. Utiliza **.NET** con **Entity Framework Core** y **PostgreSQL**.

## Estructura del Repositorio

```
/HaciendaAgricola
├── /src
│   ├── /Models              # Clases de entidades (Parcela, Cultivo, etc.)
│   ├── /Data                # DbContext (HaciendaContext.cs)
│   ├── /Migrations          # Migraciones de Entity Framework
│   ├── Program.cs           # Configuración de la app
│   ├── appsettings.json     # Configuración de la conexión
├── /docs
│   ├── DiagramaER.png       # Diagrama Entidad-Relación
│   ├── Parcial_HaciendaAgricola.pdf # Documentación teórica
├── README.md                # Este archivo
├── .gitignore               # Ignora bin, obj
```

## Requisitos

- **.NET**: Versión 8.0 o superior.
- **PostgreSQL**: Versión 15 o superior.
- **Entity Framework Core CLI**: Instalar con `dotnet tool install --global dotnet-ef`.

## Configuración

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/dslopez0618/HaciendaAgricola.git
   cd HaciendaAgricola
   ```

2. **Instalar dependencias**:
   ```bash
   dotnet restore
   ```

3. **Configurar la base de datos**:
   - Crear una base de datos en PostgreSQL (ej. `HaciendaDb`).
   - Actualizar `appsettings.json` con las credenciales:
     ```json
     {
       "ConnectionStrings": {
         "HaciendaDb": "Host=localhost;Database=HaciendaDb;Username=postgres;Password=tu_contraseña"
       }
     }
     ```

4. **Aplicar migraciones**:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Ejecutar el proyecto**:
   ```bash
   dotnet run
   ```

## Documentación

- El análisis teórico (Contextos Delimitados, Entidades, Lenguaje Ubicuo, Modelo de Datos) está en `/docs/Parcial_HaciendaAgricola.pdf`.
- El diagrama Entidad-Relación está en `/docs/DiagramaER.png`.

## Notas

- Asegúrese de tener PostgreSQL corriendo antes de aplicar migraciones.
- El esquema de la base de datos puede inspeccionarse con herramientas como **pgAdmin** o **DBeaver**.

**Autor**: Daniel Steven López Mejía  
**Asignatura**: Laboratorio de Software  
**Fecha**: 15 de mayo de 2025
