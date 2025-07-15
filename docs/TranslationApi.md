# IO.Swagger.Api.TranslationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Translation**](TranslationApi.md#translation) | **POST** /api/v1/translation | Translation

<a name="translation"></a>
# **Translation**
> TranslationResponse Translation (string model, string dtype, string input, string srcLang, string tgtLang)

Translation

Translate text between 200+ languages using NLLB models. Uses FLORES200 format for language codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranslationExample
    {
        public void main()
        {
            var apiInstance = new TranslationApi();
            var model = model_example;  // string | 
            var dtype = dtype_example;  // string | 
            var input = input_example;  // string | 
            var srcLang = srcLang_example;  // string | 
            var tgtLang = tgtLang_example;  // string | 

            try
            {
                // Translation
                TranslationResponse result = apiInstance.Translation(model, dtype, input, srcLang, tgtLang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.Translation: " + e.Message );
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
 **srcLang** | **string**|  | 
 **tgtLang** | **string**|  | 

### Return type

[**TranslationResponse**](TranslationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
