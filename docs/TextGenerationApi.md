# IO.Swagger.Api.TextGenerationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextGeneration**](TextGenerationApi.md#textgeneration) | **POST** /api/v1/text-generation | Text Generation - Multi-Provider

<a name="textgeneration"></a>
# **TextGeneration**
> TextGenerationResponse TextGeneration (string provider, string model, string input, int? topK, double? topP, double? temperature, double? repetitionPenalty, string dtype, int? maxLength, int? maxNewTokens, int? minLength, int? minNewTokens, bool? doSample, int? numBeams, int? noRepeatNgramSize, int? contextWindowSize, int? slidingWindowSize, int? attentionSinkSize, double? frequencyPenalty, double? presencePenalty, int? bosTokenId, int? maxTokens, int? randomSeed)

Text Generation - Multi-Provider

Generate text using multiple AI providers (Transformers.js, WebLLM, MediaPipe). Use the 'provider' field to specify which AI provider to use for text generation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TextGenerationExample
    {
        public void main()
        {
            var apiInstance = new TextGenerationApi();
            var provider = provider_example;  // string | 
            var model = model_example;  // string | 
            var input = input_example;  // string | 
            var topK = 56;  // int? | 
            var topP = 1.2;  // double? | 
            var temperature = 1.2;  // double? | 
            var repetitionPenalty = 1.2;  // double? | 
            var dtype = dtype_example;  // string | 
            var maxLength = 56;  // int? | 
            var maxNewTokens = 56;  // int? | 
            var minLength = 56;  // int? | 
            var minNewTokens = 56;  // int? | 
            var doSample = true;  // bool? | 
            var numBeams = 56;  // int? | 
            var noRepeatNgramSize = 56;  // int? | 
            var contextWindowSize = 56;  // int? | 
            var slidingWindowSize = 56;  // int? | 
            var attentionSinkSize = 56;  // int? | 
            var frequencyPenalty = 1.2;  // double? | 
            var presencePenalty = 1.2;  // double? | 
            var bosTokenId = 56;  // int? | 
            var maxTokens = 56;  // int? | 
            var randomSeed = 56;  // int? | 

            try
            {
                // Text Generation - Multi-Provider
                TextGenerationResponse result = apiInstance.TextGeneration(provider, model, input, topK, topP, temperature, repetitionPenalty, dtype, maxLength, maxNewTokens, minLength, minNewTokens, doSample, numBeams, noRepeatNgramSize, contextWindowSize, slidingWindowSize, attentionSinkSize, frequencyPenalty, presencePenalty, bosTokenId, maxTokens, randomSeed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextGenerationApi.TextGeneration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provider** | **string**|  | 
 **model** | **string**|  | 
 **input** | **string**|  | 
 **topK** | **int?**|  | 
 **topP** | **double?**|  | 
 **temperature** | **double?**|  | 
 **repetitionPenalty** | **double?**|  | 
 **dtype** | **string**|  | 
 **maxLength** | **int?**|  | 
 **maxNewTokens** | **int?**|  | 
 **minLength** | **int?**|  | 
 **minNewTokens** | **int?**|  | 
 **doSample** | **bool?**|  | 
 **numBeams** | **int?**|  | 
 **noRepeatNgramSize** | **int?**|  | 
 **contextWindowSize** | **int?**|  | 
 **slidingWindowSize** | **int?**|  | 
 **attentionSinkSize** | **int?**|  | 
 **frequencyPenalty** | **double?**|  | 
 **presencePenalty** | **double?**|  | 
 **bosTokenId** | **int?**|  | 
 **maxTokens** | **int?**|  | 
 **randomSeed** | **int?**|  | 

### Return type

[**TextGenerationResponse**](TextGenerationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
