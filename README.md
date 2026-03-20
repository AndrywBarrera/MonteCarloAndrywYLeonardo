# Simulación Monte Carlo — UPTC 2026

> Generador de números pseudoaleatorios por el **Método Congruencial Lineal** y estimación de áreas mediante el **Método de Monte Carlo**, desarrollado en C# Windows Forms (.NET 8).

**Autores:** Andryw Yesid Barrera Camargo · David Leonardo Mariño Ardila  
**Asignatura:** Simulación por Computador  
**Universidad:** Universidad Pedagógica y Tecnológica de Colombia — UPTC  

---

## ¿Qué hace esta aplicación?

### 1. Generador Congruencial Lineal
Implementa la fórmula:

```
X(n+1) = (a · Xn + c) mod m
Un = Xn / m  →  Un ∈ [0, 1)
```

Genera conjuntos de 20, 200, 2000, 10 000 y 20 000 números pseudoaleatorios. Detecta ciclos automáticamente y muestra la tabla completa con columnas **Iteración**, **Xn** y **Un**.

### 2. Pruebas de Aleatoriedad
Se aplican 5 pruebas estadísticas con nivel de significancia α = 0.05:

| Prueba | Hipótesis |
|--------|-----------|
| Media | μ ≈ 0.5 |
| Varianza | σ² ≈ 1/12 |
| Chi-Cuadrado | Distribución uniforme en 10 rangos |
| Kolmogorov-Smirnov | Fn(x) ≈ F(x) uniforme |
| Rachas | Ausencia de patrones sistemáticos |

### 3. Monte Carlo — Área 2
Estima el **Área 2** definida por las funciones:

```
f(x) = sin(x),  g(x) = x²,  h(x) = cos(x)
```

Con intersecciones:
- **A** = (0, 0) → sin(x) = x²  
- **B** = (π/4, √2/2) → sin(x) = cos(x)  
- **C** = (0.8241, 0.6791) → x² = cos(x)

| Región | Intervalo | Superior | Inferior |
|--------|-----------|----------|----------|
| 1 | [0, π/4] | sin(x) | x² |
| 2 | [π/4, 0.8241] | cos(x) | x² |

**Área exacta:** A₁ + A₂ = 0.1314032 + 0.0017 = **0.1331032**

Realiza estimaciones con 10, 100, 1 000, 5 000 y 10 000 coordenadas aleatorias y calcula el error teórico y real para cada conjunto.

---

## Estructura del proyecto

```
SimulacionMonteCarlo/
├── Program.cs                  # Punto de entrada
├── MonteCarloSimulacion.cs     # Lógica del formulario (eventos)
├── MonteCarloSimulacion.Designer.cs  # Interfaz gráfica (diseñador VS)
├── GeneradorCongruencial.cs    # Método congruencial lineal
├── PruebasAleatoriedad.cs      # 5 pruebas estadísticas
├── MonteCarlo.cs               # Estimación de área por Monte Carlo
└── SimulacionMonteCarlo.csproj # Configuración del proyecto
```

---

## Requisitos

- Visual Studio Community 2022 o superior
- .NET 8.0 (Windows)
- Paquete NuGet: `ScottPlot.WinForms` v5.x

---

## Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/usuario/SimulacionMonteCarlo.git
   ```
2. Abre `SimulacionMonteCarlo.csproj` en Visual Studio
3. Visual Studio restaura automáticamente el paquete ScottPlot (requiere internet)
4. Presiona **F5**

---

## Parámetros recomendados

| Parámetro | Valor |
|-----------|-------|
| Módulo (m) | `65536` |
| Multiplicador (a) | `1541` |
| Incremento (c) | `2957` |
| Semilla (X0) | `12345` |

> Estos valores corresponden al generador clásico de *Numerical Recipes* y satisfacen las condiciones de Hull-Dobell para período completo.

---

## Tecnologías

- **Lenguaje:** C# 12
- **Framework:** .NET 8.0 — Windows Forms
- **Gráficos:** ScottPlot 5
- **IDE:** Visual Studio Community 2022
