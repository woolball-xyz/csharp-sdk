/* 
 * Woolball AI Network API
 *
 * **Transform idle browsers into a powerful distributed AI inference network**  For detailed examples and model lists, visit our [GitHub repository](https://github.com/woolball-xyz/woolball-server).
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// SpeechToTextRequestContract
    /// </summary>
    [DataContract]
        public partial class SpeechToTextRequestContract :  IEquatable<SpeechToTextRequestContract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextRequestContract" /> class.
        /// </summary>
        /// <param name="model">model (required).</param>
        /// <param name="dtype">dtype (required).</param>
        /// <param name="input">input (required).</param>
        /// <param name="returnTimestamps">returnTimestamps.</param>
        /// <param name="stream">stream.</param>
        /// <param name="chunkLengthS">chunkLengthS.</param>
        /// <param name="strideLengthS">strideLengthS.</param>
        /// <param name="forceFullSequences">forceFullSequences.</param>
        /// <param name="language">language.</param>
        /// <param name="task">task.</param>
        /// <param name="numFrames">numFrames.</param>
        public SpeechToTextRequestContract(string model = default(string), string dtype = default(string), OneOfSpeechToTextRequestContractInput input = default(OneOfSpeechToTextRequestContractInput), string returnTimestamps = default(string), bool? stream = default(bool?), int? chunkLengthS = default(int?), int? strideLengthS = default(int?), bool? forceFullSequences = default(bool?), string language = default(string), string task = default(string), int? numFrames = default(int?))
        {
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for SpeechToTextRequestContract and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "dtype" is required (not null)
            if (dtype == null)
            {
                throw new InvalidDataException("dtype is a required property for SpeechToTextRequestContract and cannot be null");
            }
            else
            {
                this.Dtype = dtype;
            }
            // to ensure "input" is required (not null)
            if (input == null)
            {
                throw new InvalidDataException("input is a required property for SpeechToTextRequestContract and cannot be null");
            }
            else
            {
                this.Input = input;
            }
            this.ReturnTimestamps = returnTimestamps;
            this.Stream = stream;
            this.ChunkLengthS = chunkLengthS;
            this.StrideLengthS = strideLengthS;
            this.ForceFullSequences = forceFullSequences;
            this.Language = language;
            this.Task = task;
            this.NumFrames = numFrames;
        }
        
        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Dtype
        /// </summary>
        [DataMember(Name="dtype", EmitDefaultValue=false)]
        public string Dtype { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public OneOfSpeechToTextRequestContractInput Input { get; set; }

        /// <summary>
        /// Gets or Sets ReturnTimestamps
        /// </summary>
        [DataMember(Name="return_timestamps", EmitDefaultValue=false)]
        public string ReturnTimestamps { get; set; }

        /// <summary>
        /// Gets or Sets Stream
        /// </summary>
        [DataMember(Name="stream", EmitDefaultValue=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// Gets or Sets ChunkLengthS
        /// </summary>
        [DataMember(Name="chunk_length_s", EmitDefaultValue=false)]
        public int? ChunkLengthS { get; set; }

        /// <summary>
        /// Gets or Sets StrideLengthS
        /// </summary>
        [DataMember(Name="stride_length_s", EmitDefaultValue=false)]
        public int? StrideLengthS { get; set; }

        /// <summary>
        /// Gets or Sets ForceFullSequences
        /// </summary>
        [DataMember(Name="force_full_sequences", EmitDefaultValue=false)]
        public bool? ForceFullSequences { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public string Task { get; set; }

        /// <summary>
        /// Gets or Sets NumFrames
        /// </summary>
        [DataMember(Name="num_frames", EmitDefaultValue=false)]
        public int? NumFrames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeechToTextRequestContract {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Dtype: ").Append(Dtype).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  ReturnTimestamps: ").Append(ReturnTimestamps).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  ChunkLengthS: ").Append(ChunkLengthS).Append("\n");
            sb.Append("  StrideLengthS: ").Append(StrideLengthS).Append("\n");
            sb.Append("  ForceFullSequences: ").Append(ForceFullSequences).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  NumFrames: ").Append(NumFrames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpeechToTextRequestContract);
        }

        /// <summary>
        /// Returns true if SpeechToTextRequestContract instances are equal
        /// </summary>
        /// <param name="input">Instance of SpeechToTextRequestContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeechToTextRequestContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Dtype == input.Dtype ||
                    (this.Dtype != null &&
                    this.Dtype.Equals(input.Dtype))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.ReturnTimestamps == input.ReturnTimestamps ||
                    (this.ReturnTimestamps != null &&
                    this.ReturnTimestamps.Equals(input.ReturnTimestamps))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.ChunkLengthS == input.ChunkLengthS ||
                    (this.ChunkLengthS != null &&
                    this.ChunkLengthS.Equals(input.ChunkLengthS))
                ) && 
                (
                    this.StrideLengthS == input.StrideLengthS ||
                    (this.StrideLengthS != null &&
                    this.StrideLengthS.Equals(input.StrideLengthS))
                ) && 
                (
                    this.ForceFullSequences == input.ForceFullSequences ||
                    (this.ForceFullSequences != null &&
                    this.ForceFullSequences.Equals(input.ForceFullSequences))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Task == input.Task ||
                    (this.Task != null &&
                    this.Task.Equals(input.Task))
                ) && 
                (
                    this.NumFrames == input.NumFrames ||
                    (this.NumFrames != null &&
                    this.NumFrames.Equals(input.NumFrames))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Dtype != null)
                    hashCode = hashCode * 59 + this.Dtype.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.ReturnTimestamps != null)
                    hashCode = hashCode * 59 + this.ReturnTimestamps.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.ChunkLengthS != null)
                    hashCode = hashCode * 59 + this.ChunkLengthS.GetHashCode();
                if (this.StrideLengthS != null)
                    hashCode = hashCode * 59 + this.StrideLengthS.GetHashCode();
                if (this.ForceFullSequences != null)
                    hashCode = hashCode * 59 + this.ForceFullSequences.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Task != null)
                    hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.NumFrames != null)
                    hashCode = hashCode * 59 + this.NumFrames.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
