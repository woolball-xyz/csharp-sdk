# IO.Swagger.Api.SpeechRecognitionApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpeechToText**](SpeechRecognitionApi.md#speechtotext) | **POST** /api/v1/speech-recognition | Speech Recognition (Speech-to-Text)

<a name="speechtotext"></a>
# **SpeechToText**
> List<STTChunk> SpeechToText (string model, string dtype, Object input, string returnTimestamps, bool? stream, int? chunkLengthS, int? strideLengthS, bool? forceFullSequences, string language, string task, int? numFrames)

Speech Recognition (Speech-to-Text)

Convert audio files to text using Whisper models. Supports MP3, WAV, M4A and other audio formats.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SpeechToTextExample
    {
        public void main()
        {
            var apiInstance = new SpeechRecognitionApi();
            var model = model_example;  // string | 
            var dtype = dtype_example;  // string | 
            var input = new Object(); // Object | 
            var returnTimestamps = returnTimestamps_example;  // string | 
            var stream = true;  // bool? | 
            var chunkLengthS = 56;  // int? | 
            var strideLengthS = 56;  // int? | 
            var forceFullSequences = true;  // bool? | 
            var language = language_example;  // string | 
            var task = task_example;  // string | 
            var numFrames = 56;  // int? | 

            try
            {
                // Speech Recognition (Speech-to-Text)
                List&lt;STTChunk&gt; result = apiInstance.SpeechToText(model, dtype, input, returnTimestamps, stream, chunkLengthS, strideLengthS, forceFullSequences, language, task, numFrames);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechRecognitionApi.SpeechToText: " + e.Message );
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
 **input** | [**Object**](Object.md)|  | 
 **returnTimestamps** | **string**|  | 
 **stream** | **bool?**|  | 
 **chunkLengthS** | **int?**|  | 
 **strideLengthS** | **int?**|  | 
 **forceFullSequences** | **bool?**|  | 
 **language** | **string**|  | 
 **task** | **string**|  | 
 **numFrames** | **int?**|  | 

### Return type

[**List<STTChunk>**](STTChunk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
