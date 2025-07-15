# IO.Swagger.Api.TextToSpeechApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextToSpeech**](TextToSpeechApi.md#texttospeech) | **POST** /api/v1/text-to-speech | Text-to-Speech

<a name="texttospeech"></a>
# **TextToSpeech**
> List<TTSResponse> TextToSpeech (string model, string dtype, string input, string voice, bool? stream)

Text-to-Speech

Generate natural speech from text using MMS or Kokoro models. Supports multiple languages and premium voices.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TextToSpeechExample
    {
        public void main()
        {
            var apiInstance = new TextToSpeechApi();
            var model = model_example;  // string | 
            var dtype = dtype_example;  // string | 
            var input = input_example;  // string | 
            var voice = voice_example;  // string | 
            var stream = true;  // bool? | 

            try
            {
                // Text-to-Speech
                List&lt;TTSResponse&gt; result = apiInstance.TextToSpeech(model, dtype, input, voice, stream);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextToSpeechApi.TextToSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | **string**|  | 
 **dtype** | **string**|  | 
 **input** | **string**|  | 
 **voice** | **string**|  | 
 **stream** | **bool?**|  | 

### Return type

[**List<TTSResponse>**](TTSResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
