# IO.Swagger.Model.TextGenerationRequestContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | The AI provider to use | 
**Model** | **string** | The AI model to use for processing | 
**Input** | **string** | Input text or messages for generation | 
**TopK** | **int?** | The number of highest probability vocabulary tokens to keep for top-k-filtering | [optional] 
**TopP** | **double?** | If set to float &lt; 1, only the smallest set of most probable tokens with probabilities that add up to top_p or higher are kept for generation | [optional] 
**Temperature** | **double?** | The value used to modulate the next token probabilities | [optional] 
**RepetitionPenalty** | **double?** | Parameter for repetition penalty. 1.0 means no penalty | [optional] 
**Dtype** | **string** | Quantization level (e.g., &#x27;fp16&#x27;, &#x27;q4&#x27;, &#x27;q8&#x27;) - Transformers only | [optional] 
**MaxLength** | **int?** | Maximum length the generated tokens can have - Transformers only | [optional] 
**MaxNewTokens** | **int?** | Maximum number of tokens to generate - Transformers only | [optional] 
**MinLength** | **int?** | Minimum length of the sequence to be generated - Transformers only | [optional] 
**MinNewTokens** | **int?** | Minimum numbers of tokens to generate - Transformers only | [optional] 
**DoSample** | **bool?** | Whether to use sampling - Transformers only | [optional] 
**NumBeams** | **int?** | Number of beams for beam search - Transformers only | [optional] 
**NoRepeatNgramSize** | **int?** | If &gt; 0, all ngrams of that size can only occur once - Transformers only | [optional] 
**ContextWindowSize** | **int?** | Size of the context window for the model - WebLLM only | [optional] 
**SlidingWindowSize** | **int?** | Size of the sliding window for attention - WebLLM only | [optional] 
**AttentionSinkSize** | **int?** | Size of the attention sink - WebLLM only | [optional] 
**FrequencyPenalty** | **double?** | Penalty for token frequency - WebLLM only | [optional] 
**PresencePenalty** | **double?** | Penalty for token presence - WebLLM only | [optional] 
**BosTokenId** | **int?** | Beginning of sequence token ID - WebLLM only | [optional] 
**MaxTokens** | **int?** | Maximum number of tokens to generate - MediaPipe only | [optional] 
**RandomSeed** | **int?** | Random seed for reproducible results - MediaPipe only | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

