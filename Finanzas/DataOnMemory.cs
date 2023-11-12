namespace Finanzas;

public static class DataOnMemory
{
    public static IEnumerable<Topic> Topics =>
        new List<Topic>()
        {
            new Topic() { TopicId= 1, Color = new Color(150, 150, 130),  Name ="Bonos", Image = "business.png", Description="Sección de bonos sobre inversiones en bonos", ReadTime="10 min",
                Concepts = Concepts.Take(15)
            },
            
            new Topic() { TopicId= 2, Color = new Color(100, 128, 128),  Name="Acciones", Image = "finance.png", Description="Sección de acciones en el mercado financiero", ReadTime="15 min",
                Concepts = Concepts.Skip(15).Take(15)
            },
            
            new Topic() { TopicId= 3, Color = new Color(255, 204, 0),  Name="Apalancamiento", Image = "bars.png", Description="Conceptos de apalancamiento financiero", ReadTime="8 min",
                Concepts = Concepts.Skip(30).Take(15)
            },
            
            new Topic() { TopicId= 4, Color = new Color(192, 192, 192),  Name="Arrendamiento", Image = "money.png", Description="Arrendamiento financiero y sus ventajas", ReadTime="12 min",
                Concepts = Concepts.Skip(45).Take(15)
            },
            
            new Topic() { TopicId= 5, Color = new Color(255, 0, 255),  Name="Razones Financieras", Image = "business.png", Description="Análisis de razones financieras", ReadTime="20 min",
                Concepts = Concepts.Skip(60).Take(15)
            }
        };

    public static IEnumerable<Concept> Concepts =>
        new List<Concept>()
        {
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 1,  TopicId = 1, Title = "Tasa de interés", ConceptText = "Se aplica normalmente a instrumentos de deuda como los préstamos bancarios o bonos; es la compensación que paga el prestatario de fondos al prestamista; desde el punto de vista del prestatario, es el costo de solicitar fondos en préstamo." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 2,  TopicId = 1, Title = "Rendimiento Requerido", ConceptText = "rendimiento requerido Por lo general se aplica a los instrumentos patrimoniales, como las acciones comunes; es el costo de los fondos obtenidos por medio de la venta de una participación en la propiedad." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 3,  TopicId = 1, Title = "Inflación", ConceptText = "inflación Tendencia a la alza en los precios de la mayoría de los bienes y servicios." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 4,  TopicId = 1, Title = "Preferencia de liquidez", ConceptText = "preferencia de liquidez Tendencia general de los inversionistas al preferir los valores a corto plazo (es decir, los que tienen mayor liquidez)." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 5,  TopicId = 1, Title = "Tasa de Interés real", ConceptText = "Tasa que crea un equilibrio entre la oferta de ahorros y la demanda de fondos de inversión en un mundo perfecto, sin inflación, donde los proveedores y los demandantes de fondos no tienen preferencias de liquidez y no existe riesgo alguno." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 6,  TopicId = 1, Title = "Tasa de interés nominal", ConceptText = "Tasa de interés que realmente cobra el proveedor de fondos y paga el demandante de fondo." },

            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 7,  TopicId = 1, Title = "Prima de Riesgo", ConceptText = "La cantidad adicional de rendimiento exigida por los inversores para asumir un riesgo mayor." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 8,  TopicId = 1, Title = "Rendimiento al Vencimiento", ConceptText = "La tasa de rendimiento anual que un inversionista ganaría si el bono se mantiene hasta su vencimiento." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 9,  TopicId = 1, Title = "Bono Convertible", ConceptText = "Un bono que se puede convertir en acciones de la empresa emisora." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 10, TopicId = 1, Title = "Riesgo de Tipo de Cambio", ConceptText = "El riesgo de pérdida debido a las fluctuaciones en las tasas de cambio." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 11, TopicId = 1, Title = "Bono de Tasa Fija", ConceptText = "Un bono que paga un interés fijo durante la vida del bono." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 12, TopicId = 1, Title = "Bono de Tasa Variable", ConceptText = "Un bono cuyo interés se ajusta periódicamente según un índice de referencia." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 13, TopicId = 1, Title = "Bono Subordinado", ConceptText = "Un bono que tiene un menor rango de pago en caso de quiebra de la empresa emisora." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 14, TopicId = 1, Title = "Bono Junk", ConceptText = "Un bono con una calificación crediticia baja y mayor riesgo de incumplimiento." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 15, TopicId = 1, Title = "Riesgo de Inflación", ConceptText = "El riesgo de que la inflación reduzca el poder adquisitivo del dinero invertido en bonos." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 16, TopicId = 2, Title = "Acciones Comunes", ConceptText = "Representan propiedad en una empresa y otorgan derechos de voto en las decisiones corporativas." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 17, TopicId = 2, Title = "Dividendos", ConceptText = "Pagos periódicos a los accionistas como parte de las ganancias de la empresa." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 18, TopicId = 2, Title = "Acciones Preferentes", ConceptText = "Clase de acciones que generalmente reciben dividendos antes que las acciones comunes y tienen prioridad en el reembolso en caso de quiebra." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 19, TopicId = 2, Title = "Valor Nominal", ConceptText = "El valor nominal o par de una acción, establecido en el momento de la emisión." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 20, TopicId = 2, Title = "Oferta Pública Inicial (IPO)", ConceptText = "El primer ofrecimiento de acciones de una empresa al público." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 21, TopicId = 2, Title = "Índice Bursátil", ConceptText = "Una medida estadística de un segmento del mercado de valores, compuesto por un grupo de acciones seleccionadas." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 22, TopicId = 2, Title = "Broker", ConceptText = "Un intermediario que facilita la compra y venta de acciones en el mercado." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 23, TopicId = 2, Title = "Capitalización de Mercado", ConceptText = "El valor total de mercado de todas las acciones en circulación de una empresa." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 24, TopicId = 2, Title = "Análisis Fundamental", ConceptText = "Evaluación de una acción basada en factores financieros y económicos que afectan a la empresa emisora." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 25, TopicId = 2, Title = "Análisis Técnico", ConceptText = "Evaluación de una acción basada en patrones y tendencias de precios históricos." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 26, TopicId = 2, Title = "Blue Chip Stocks", ConceptText = "Acciones de empresas líderes y establecidas con historial de estabilidad financiera." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 27, TopicId = 2, Title = "Acciones de Crecimiento", ConceptText = "Acciones de empresas con perspectivas de crecimiento significativo en ingresos y ganancias." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 28, TopicId = 2, Title = "Acciones de Valor", ConceptText = "Acciones consideradas subvaloradas en relación con su desempeño financiero." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 29, TopicId = 2, Title = "Dividendo por Acción (DPA)", ConceptText = "La cantidad de dividendos pagados por acción emitida." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 30, TopicId = 2, Title = "Acciones Penny", ConceptText = "Acciones de bajo precio, generalmente negociadas por debajo de $5 por acción." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 31, TopicId = 3, Title = "Apalancamiento Financiero", ConceptText = "Uso de deuda para financiar operaciones y aumentar el rendimiento de la inversión." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 32, TopicId = 3, Title = "Ratio de Apalancamiento", ConceptText = "Proporción de deuda utilizada en relación con el capital propio en una inversión o empresa." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 33, TopicId = 3, Title = "Apalancamiento Operativo", ConceptText = "Uso de costos fijos para aumentar la rentabilidad de una empresa." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 34, TopicId = 3, Title = "Margen de Apalancamiento", ConceptText = "Diferencia entre el rendimiento de la inversión con apalancamiento y sin apalancamiento." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 35, TopicId = 3, Title = "Límite de Apalancamiento", ConceptText = "La cantidad máxima de deuda que una empresa o individuo puede utilizar para una inversión." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 36, TopicId = 3, Title = "Apalancamiento Positivo", ConceptText = "El efecto positivo del apalancamiento que aumenta los rendimientos." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 37, TopicId = 3, Title = "Apalancamiento Negativo", ConceptText = "El efecto negativo del apalancamiento que aumenta las pérdidas potenciales." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 38, TopicId = 3, Title = "Apalancamiento Operativo", ConceptText = "Uso de costos fijos para aumentar la rentabilidad de una empresa." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 39, TopicId = 3, Title = "Apalancamiento Total", ConceptText = "La combinación de apalancamiento financiero y operativo en una empresa." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 40, TopicId = 3, Title = "Préstamo Apalancado", ConceptText = "Un préstamo respaldado por garantías que permite a los inversionistas aumentar su exposición a una inversión." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 41, TopicId = 3, Title = "Efecto de Palanca", ConceptText = "La amplificación de los rendimientos y las pérdidas debido al uso de apalancamiento." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 42, TopicId = 3, Title = "Apalancamiento de Mercado", ConceptText = "Uso de instrumentos financieros para aumentar la exposición a movimientos del mercado." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 43, TopicId = 3, Title = "Riesgo de Apalancamiento", ConceptText = "El riesgo de pérdida amplificada debido al uso de apalancamiento." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 44, TopicId = 3, Title = "Apalancamiento Ajustado al Riesgo", ConceptText = "Evaluación del apalancamiento en función del riesgo asumido." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 45, TopicId = 3, Title = "Call de Margen", ConceptText = "Requerimiento de depositar fondos adicionales debido a pérdidas en una posición apalancada." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 46, TopicId = 4, Title = "Arrendamiento Financiero", ConceptText = "Un contrato de arrendamiento a largo plazo que se asemeja a la propiedad y generalmente implica la transferencia de la propiedad al arrendatario al final del contrato." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 47, TopicId = 4, Title = "Arrendador", ConceptText = "La parte que posee el activo y arrienda el bien al arrendatario." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 48, TopicId = 4, Title = "Arrendatario", ConceptText = "La parte que arrienda el activo del arrendador." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 49, TopicId = 4, Title = "Arrendamiento Operativo", ConceptText = "Un contrato de arrendamiento a corto plazo que no transfiere la propiedad y generalmente se utiliza para bienes de consumo." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 50, TopicId = 4, Title = "Valor Residual", ConceptText = "El valor estimado de un activo al final del período de arrendamiento." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 51, TopicId = 4, Title = "Costos Iniciales de Arrendamiento", ConceptText = "Los costos incurridos al inicio de un contrato de arrendamiento, como tarifas y costos legales." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 52, TopicId = 4, Title = "Periodo de Arrendamiento", ConceptText = "El tiempo durante el cual el arrendatario tiene el derecho de usar el activo arrendado." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 53, TopicId = 4, Title = "Arrendamiento Capitalizado", ConceptText = "El arrendamiento financiero donde se reconoce el activo arrendado y la obligación de arrendamiento en el balance del arrendatario." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 54, TopicId = 4, Title = "Valor Presente de los Pagos de Arrendamiento", ConceptText = "El valor actual de todos los pagos futuros de arrendamiento, utilizado para calcular los pasivos por arrendamiento." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 55, TopicId = 4, Title = "Arrendamiento Directo", ConceptText = "Un acuerdo en el que el arrendador adquiere un activo para luego arrendárselo al arrendatario." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 56, TopicId = 4, Title = "Arrendamiento Financiero Directo", ConceptText = "Un tipo de arrendamiento directo donde el arrendatario reconoce el activo y la deuda por el arrendamiento desde el principio." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 57, TopicId = 4, Title = "CLA (Contrato de Leasing)", ConceptText = "El documento que establece los términos y condiciones del arrendamiento." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 58, TopicId = 4, Title = "Amortización de Arrendamiento", ConceptText = "La distribución sistemática de los costos de un arrendamiento a lo largo del período de arrendamiento." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 59, TopicId = 4, Title = "Gastos de Arrendamiento", ConceptText = "Los costos continuos asociados con el mantenimiento y operación de un activo arrendado." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 60, TopicId = 4, Title = "Arrendamiento a Término", ConceptText = "Un arrendamiento con un plazo fijo y sin opción de compra al final del período de arrendamiento." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 165, 0), ConceptId = 61, TopicId = 5, Title = "Razón de Liquidez", ConceptText = "Mide la capacidad de una empresa para cumplir con sus obligaciones a corto plazo, como la razón rápida y la razón de efectivo." },
            new Concept { Image = "blackboard.png"   , Color = new Color(245, 165, 0), ConceptId = 62, TopicId = 5, Title = "Razón de Endeudamiento", ConceptText = "Evalúa el nivel de deuda de una empresa en relación con su capital propio, incluyendo la razón de deuda a capital y la razón de deuda a activos." },
            new Concept { Image = "presentation.png" , Color = new Color(240, 165, 0), ConceptId = 63, TopicId = 5, Title = "Margen de Beneficio Neto", ConceptText = "Calcula la rentabilidad neta de las ventas, mostrando cuánto queda después de todos los gastos." },
            new Concept { Image = "formul.png"       , Color = new Color(235, 165, 0), ConceptId = 64, TopicId = 5, Title = "Margen Bruto", ConceptText = "Mide la rentabilidad de una empresa en relación con sus ingresos, restando solo el costo de los bienes vendidos." },
            new Concept { Image = "formula.png"      , Color = new Color(255, 150, 0), ConceptId = 65, TopicId = 5, Title = "ROA (Retorno sobre Activos)", ConceptText = "Indica la eficiencia de una empresa en el uso de sus activos para generar ganancias." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 66, TopicId = 5, Title = "ROE (Retorno sobre el Patrimonio)", ConceptText = "Muestra la rentabilidad de una empresa en relación con su capital propio." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 67, TopicId = 5, Title = "Índice de Cobertura de Intereses", ConceptText = "Evalúa la capacidad de una empresa para cumplir con sus obligaciones de intereses sobre la deuda." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 68, TopicId = 5, Title = "Rotación de Inventarios", ConceptText = "Indica cuántas veces una empresa convierte su inventario en ingresos durante un período específico." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 69, TopicId = 5, Title = "Razón de Pago de Cuentas", ConceptText = "Mide la rapidez con la que una empresa paga a sus proveedores." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 70, TopicId = 5, Title = "Índice de Eficiencia", ConceptText = "Evalúa la eficiencia operativa de una empresa en términos de ingresos generados por cada dólar de gastos." },
            new Concept { Image = "calculator.png"   , Color = new Color(255, 155, 0), ConceptId = 71, TopicId = 5, Title = "Margen de Operación", ConceptText = "Calcula la rentabilidad de una empresa antes de impuestos e intereses, evaluando su eficiencia operativa." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 110, 0), ConceptId = 72, TopicId = 5, Title = "Razón de Cobertura de Dividendos", ConceptText = "Indica la capacidad de una empresa para pagar sus dividendos a los accionistas." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 140, 0), ConceptId = 73, TopicId = 5, Title = "Giro de Cuentas por Cobrar", ConceptText = "Muestra la rapidez con la que una empresa convierte sus cuentas por cobrar en efectivo." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 74, TopicId = 5, Title = "Razón de Capital de Trabajo", ConceptText = "Evalúa la capacidad de una empresa para cubrir sus obligaciones a corto plazo mediante activos corrientes." },
            new Concept { Image = "money_bag.png"    , Color = new Color(255, 150, 0), ConceptId = 75, TopicId = 5, Title = "Razón de Eficiencia de Capital", ConceptText = "Mide la eficiencia de una empresa en la utilización de su capital para generar ingresos." }
        };
}
