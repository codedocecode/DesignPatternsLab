# 📘 Design Patterns Catalog – 2026 (.NET / Java)

## ⭐ Nivel 1 – ESENCIALES (dominar)

### Strategy
**Problema:** Variantes de comportamiento.
**Solución:** Encapsular algoritmos intercambiables.
**Cuándo usar:** Reglas de negocio, pricing, validaciones.
**Ejemplo:** Estrateg_use cases para cálculo de precios.

### State
**Problema:** Lógica condicional basada en estado.
**Solución:** Estados explícitos con transiciones.
**Cuándo usar:** Flujos de pedidos, workflows.
**Ejemplo:** Pedido: Created → Paid → Shipped → Completed.

### Command
**Problema:** Acciones desacopladas del emisor.
**Solución:** Encapsular una acción como objeto.
**Cuándo usar:** Casos de uso, CQRS light.
**Ejemplo:** CreateOrderCommand.

### Observer
**Problema:** Reaccionar a eventos sin acoplar.
**Solución:** Suscriptores a eventos.
**Cuándo usar:** Domain events.
**Ejemplo:** OrderPaidEvent.

### Chain of Responsibility
**Problema:** Procesos secuenciales y condicionales.
**Solución:** Cadena de handlers.
**Cuándo usar:** Middlewares, validaciones.
**Ejemplo:** Pipeline de validación de pedidos.

### Repository
**Problema:** Acoplamiento a persistencia.
**Solución:** Abstracción del acceso a datos.
**Cuándo usar:** Siempre en dominio rico.
**Ejemplo:** IOrderRepository.

### Unit of Work
**Problema:** Consistencia transaccional.
**Solución:** Coordinar cambios como unidad.
**Cuándo usar:** Persistencia.
**Ejemplo:** DbContext.

---

## 🟡 Nivel 2 – IMPORTANTES (saber bien, usar menos)

### Decorator
Uso moderno: Middleware, interceptors.

### Proxy
Uso moderno: AOP, lazy loading, seguridad.

### Facade
Uso moderno: Application Services.

### Adapter
Uso moderno: Integración de APIs externas.

### Factory Method / Abstract Factory
Uso moderno: SDKs, librerías, código sin DI.

---

## 🔴 Nivel 3 – CULTURA GENERAL

### Singleton
Reemplazado por DI.

### Visitor
Útil en compiladores, poco en negocio.

### Prototype
Clonado raro en enterprise.

### Interpreter
DSLs usan parsers modernos.

### Flyweight
Optimización extrema de memoria.

---