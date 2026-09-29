using System;
using System.Collections.Generic;


namespace Analizador_Léxico_PQ_DJ_EM.Clases
{
    internal class LecturaAnalizador
    {
        int IdLecturaA { get; set; }

        String Resultado { get; set; }

        String Error { get; set; }

        private List<tbResultados> listaTokens;
        private List<tbError> listaErrores;
        private TablaDeSimbolos tablaSimbolos;

        private readonly HashSet<string> palabrasReservadas = new HashSet<string>()
        {
            "int", "float", "double", "char", "bool", "string", "void",
            "if", "else", "while", "for", "switch", "case", "break", "continue", "return",
            "class", "static", "true", "false", "foreach"
        };

        public LecturaAnalizador()
        {
            listaTokens = new List<tbResultados>();
            listaErrores = new List<tbError>();
            tablaSimbolos = new TablaDeSimbolos();
        }

        public List<tbResultados> ObtenerTokens() => listaTokens;
        public List<tbError> ObtenerErrores() => listaErrores;
        public TablaDeSimbolos ObtenerTablaSimbolos() => tablaSimbolos;

        public void AnalizarTexto(string contenidoFuente)
        {
            listaTokens.Clear();
            listaErrores.Clear();
            tablaSimbolos.Limpiar();

            int posicion = 0;
            int longitud = contenidoFuente.Length;
            int lineaActual = 1;
            int columnaActual = 1;
            int idResultCounter = 1;
            int idErrorCounter = 1;

            while (posicion < longitud)
            {
                char c = contenidoFuente[posicion];

                if (c == '\n')
                {
                    lineaActual++;
                    columnaActual = 1;
                    posicion++;
                    continue;
                }
                if (c == '\r')
                {
                    posicion++;
                    continue;
                }
                if (char.IsWhiteSpace(c))
                {
                    columnaActual++;
                    posicion++;
                    continue;
                }

                if (c == '/')
                {
                    if (posicion + 1 < longitud && contenidoFuente[posicion + 1] == '/')
                    {
                        while (posicion < longitud && contenidoFuente[posicion] != '\n')
                        {
                            posicion++;
                            columnaActual++;
                        }
                        continue;
                    }
                    else if (posicion + 1 < longitud && contenidoFuente[posicion + 1] == '*')
                    {
                        int colInicio = columnaActual;
                        int linInicio = lineaActual;
                        posicion += 2;
                        columnaActual += 2;
                        bool cerrado = false;

                        while (posicion < longitud)
                        {
                            if (contenidoFuente[posicion] == '\n')
                            {
                                lineaActual++;
                                columnaActual = 1;
                                posicion++;
                            }
                            else if (contenidoFuente[posicion] == '*' && posicion + 1 < longitud && contenidoFuente[posicion + 1] == '/')
                            {
                                posicion += 2;
                                columnaActual += 2;
                                cerrado = true;
                                break;
                            }
                            else
                            {
                                posicion++;
                                columnaActual++;
                            }
                        }

                        if (!cerrado)
                        {
                            listaErrores.Add(new tbError(idErrorCounter++, linInicio, colInicio, "/*", "Comentario de bloque no cerrado"));
                        }
                        continue;
                    }
                }

                if (char.IsLetter(c) || c == '_')
                {
                    int colInicio = columnaActual;
                    string lexema = "";

                    while (posicion < longitud && (char.IsLetterOrDigit(contenidoFuente[posicion]) || contenidoFuente[posicion] == '_'))
                    {
                        lexema += contenidoFuente[posicion];
                        posicion++;
                        columnaActual++;
                    }

                    string tipo = palabrasReservadas.Contains(lexema) ? "TK_PALABRAS_RESERVADAS" : "TK_IDENTIFICADOR";
                    listaTokens.Add(new tbResultados(idResultCounter++, 1, lexema, tipo, lineaActual, colInicio));

                    if (tipo == "TK_IDENTIFICADOR")
                    {
                        tablaSimbolos.AgregarIdentificador(lexema, lineaActual);
                    }
                    continue;
                }

                if (char.IsDigit(c))
                {
                    int colInicio = columnaActual;
                    string lexema = "";
                    bool tienePunto = false;

                    while (posicion < longitud)
                    {
                        char actual = contenidoFuente[posicion];
                        if (char.IsDigit(actual))
                        {
                            lexema += actual;
                            posicion++;
                            columnaActual++;
                        }
                        else if (actual == '.' && !tienePunto)
                        {
                            if (posicion + 1 < longitud && char.IsDigit(contenidoFuente[posicion + 1]))
                            {
                                tienePunto = true;
                                lexema += actual;
                                posicion++;
                                columnaActual++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    string tipo = tienePunto ? "TK_NUMEROS_REALES" : "TK_NUMEROS_REALES";
                    listaTokens.Add(new tbResultados(idResultCounter++, 2, lexema, tipo, lineaActual, colInicio));
                    continue;
                }

                if (c == '"')
                {
                    int colInicio = columnaActual;
                    string lexema = "\"";
                    posicion++;
                    columnaActual++;
                    bool cerrada = false;

                    while (posicion < longitud)
                    {
                        char actual = contenidoFuente[posicion];
                        if (actual == '"')
                        {
                            lexema += "\"";
                            posicion++;
                            columnaActual++;
                            cerrada = true;
                            break;
                        }
                        else if (actual == '\n')
                        {
                            break;
                        }
                        else
                        {
                            lexema += actual;
                            posicion++;
                            columnaActual++;
                        }
                    }

                    if (cerrada)
                    {
                        listaTokens.Add(new tbResultados(idResultCounter++, 3, lexema, "TK_CADENA", lineaActual, colInicio));
                    }
                    else
                    {
                        listaErrores.Add(new tbError(idErrorCounter++, lineaActual, colInicio, lexema, "Cadena de caracteres no cerrada correctamente"));
                    }
                    continue;
                }

                if (posicion + 1 < longitud)
                {
                    string subDos = contenidoFuente.Substring(posicion, 2);
                    if (subDos == "==" || subDos == "!=" || subDos == "<=" || subDos == "=>")
                    {
                        listaTokens.Add(new tbResultados(idResultCounter++, 6, subDos, "TK_OP_RELACIONALES", lineaActual, columnaActual));
                        posicion += 2;
                        columnaActual += 2;
                        continue;
                    }
                    if (subDos == "&&" || subDos == "||")
                    {
                        listaTokens.Add(new tbResultados(idResultCounter++, 7, subDos, "TK_OP_LOGICO", lineaActual, columnaActual));
                        posicion += 2;
                        columnaActual += 2;
                        continue;
                    }
                }

                if (c == '+' || c == '-')
                {
                    listaTokens.Add(new tbResultados(idResultCounter++, 4, c.ToString(), "TK_OP_SUMA", lineaActual, columnaActual));
                    posicion++; columnaActual++;
                    continue;
                }
                if (c == '*' || c == '/')
                {
                    listaTokens.Add(new tbResultados(idResultCounter++, 5, c.ToString(), "TK_OP_MULTIPLICACION", lineaActual, columnaActual));
                    posicion++; columnaActual++;
                    continue;
                }
                if (c == ';' || c == ':' || c == ',' || c == '.' || c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']')
                {
                    listaTokens.Add(new tbResultados(idResultCounter++, 6, c.ToString(), "TK_PUNTUACION", lineaActual, columnaActual));
                    posicion++; columnaActual++;
                    continue;
                }
                if (c == '<' || c == '>')
                {
                    listaTokens.Add(new tbResultados(idResultCounter++, 8, c.ToString(), "TK_OP_RELACIONALES", lineaActual, columnaActual));
                    posicion++; columnaActual++;
                    continue;
                }
                if (c == '=' || c == '!' || c == 'v' || c == '^' || c == '\\')
                {
                    string tipo = (c == '=') ? "TK_OP_RELACIONALES" : "TK_OP_LOGICO";
                    listaTokens.Add(new tbResultados(idResultCounter++, 7, c.ToString(), tipo, lineaActual, columnaActual));
                    posicion++; columnaActual++;
                    continue;
                }

                listaErrores.Add(new tbError(idErrorCounter++, lineaActual, columnaActual, c.ToString(), "Carácter no reconocido en el alfabeto del lenguaje"));
                posicion++;
                columnaActual++;
            }
        }
    }

}
