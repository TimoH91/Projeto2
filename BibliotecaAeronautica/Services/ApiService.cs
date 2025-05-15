using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Entities;
using Newtonsoft.Json;
using BibliotecaAeronautica.DTOs;
using Newtonsoft.Json.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Diagnostics;

namespace BibliotecaAeronautica.Services
{
    public class ApiService
    {
        public async Task<Response> GetAeroportos(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var aeroportos = JsonConvert.DeserializeObject<List<Aeroporto>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = aeroportos
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetAeroportoById(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response { IsSuccess = false, Message = result };
                }

                var aeroporto = JsonConvert.DeserializeObject<Aeroporto>(result); 

                return new Response { IsSuccess = true, Result = aeroporto };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }
        }


        public async Task<Response> PostAssento(string urlBase, string controller, Assento assento)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                // Serialize the object to JSON
                var json = JsonConvert.SerializeObject(assento);

                // Create HttpContent with the JSON and proper encoding & content type
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Make POST request with content
                var response = await client.PostAsync(controller, content);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                Assento assentoDevolvido = JsonConvert.DeserializeObject<Assento>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = assentoDevolvido
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }


        public async Task<Response> GetAssentos(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var assentos = JsonConvert.DeserializeObject<List<Assento>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = assentos
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetAssentoById(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var assento = JsonConvert.DeserializeObject<Assento>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = assento
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        //public async Task<Response> GetAssentosResumo(string urlBase, string controller)
        //{
        //    try
        //    {
        //        var client = new HttpClient();
        //        client.BaseAddress = new Uri(urlBase);

        //        var response = await client.GetAsync(controller);

        //        var result = await response.Content.ReadAsStringAsync();

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Response
        //            {
        //                IsSuccess = false,
        //                Message = result,
        //            };
        //        }

        //        var assentos = JsonConvert.DeserializeObject<List<AssentoResumoDto>>(result);

        //        return new Response
        //        {
        //            IsSuccess = true,
        //            Result = assentos
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Response
        //        {
        //            IsSuccess = false,
        //            Message = ex.Message
        //        };
        //    }
        //}

        public async Task<Response> GetAvioes(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var avioes = JsonConvert.DeserializeObject<List<Aviao>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = avioes
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetBilhetes(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var list = JsonConvert.DeserializeObject<List<JObject>>(result);

                List<Bilhete>bilhetesTodos = new List<Bilhete>();
                var bilhetesAdultos = new List<String>();
                var bilhetesCriancas = new List<String>();
                var bilhetesBebes = new List<String>();
                //List<BilheteAdulto> bilhetesAdultosActual = new List<BilheteAdulto>();
                //List<BilheteCrianca> bilhetesCriancasActual = new List<BilheteCrianca>();
                //List<BilheteBebe> bilhetesBebesActual = new List<BilheteBebe>();

                foreach (var item in list)
                {
                    var tipo = item["Tipo"]?.ToString();

                    if (tipo == "Adulto")
                        bilhetesAdultos.Add(item.ToString());
                    else if (tipo == "Crianca")
                        bilhetesCriancas.Add(item.ToString());
                    else if (tipo == "Bebe")
                        bilhetesBebes.Add(item.ToString());
                }

                for(int i = 0; i < bilhetesAdultos.Count; i++) 
                {
                    bilhetesTodos.Add(JsonConvert.DeserializeObject<BilheteAdulto>(bilhetesAdultos[i]));
                    //bilhetesAdultosActual.Add(JsonConvert.DeserializeObject<BilheteAdulto>(bilhetesAdultos[i]));
                }
                for (int i = 0; i < bilhetesCriancas.Count; i++)
                {
                    bilhetesTodos.Add(JsonConvert.DeserializeObject<BilheteCrianca>(bilhetesCriancas[i]));
                    //bilhetesCriancasActual.Add(JsonConvert.DeserializeObject<BilheteCrianca>(bilhetesCriancas[i]));
                }
                for (int i = 0; i < bilhetesBebes.Count; i++)
                {
                    bilhetesTodos.Add(JsonConvert.DeserializeObject<BilheteBebe>(bilhetesBebes[i]));
                    //bilhetesBebesActual.Add(JsonConvert.DeserializeObject<BilheteBebe>(bilhetesBebes[i]));
                }


                

                return new Response
                {
                    IsSuccess = true,
                    Result = bilhetesTodos
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

        }

        public async Task<Response> GetBilheteById(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var bilhete = JsonConvert.DeserializeObject<Bilhete>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = bilhete
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> PutBilhete(string urlBase, string controller, Bilhete bilhete)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                
                var json = JsonConvert.SerializeObject(bilhete);
                Debug.WriteLine(json);

                // Create HttpContent with the JSON and proper encoding & content type
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Make POST request with content
                var response = await client.PutAsync(controller, content);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                Bilhete bilheteDevolvido = JsonConvert.DeserializeObject<Bilhete>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = bilheteDevolvido
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetBilhetesResumo(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var bilhetes = JsonConvert.DeserializeObject<List<BilheteResumoDto>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = bilhetes
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetVoos(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var voos = JsonConvert.DeserializeObject<List<Voo>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = voos
                };
            }
            catch (Exception ex)
            {
                
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetVooById(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var voo = JsonConvert.DeserializeObject<Voo>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = voo
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> GetVoosResumo(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var voos = JsonConvert.DeserializeObject<List<VooResumoDto>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = voos
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> DeleteBilhete(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.DeleteAsync($"{controller}");
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response 
                    {
                        IsSuccess = false, 
                        Message = result 
                    };
                }

                return new Response 
                { 
                    IsSuccess = true, 
                    Message = "Bilhete apagado com sucesso" 
                
                };
            }
            catch (Exception ex)
            {
                return new Response 
                { 
                    IsSuccess = false,
                    Message = ex.Message 
                };
            }
        }
    }
}
