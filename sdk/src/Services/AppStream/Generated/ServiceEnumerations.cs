/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppStream
{

    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant API for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType API = new AuthenticationType("API");
        /// <summary>
        /// Constant SAML for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType SAML = new AuthenticationType("SAML");
        /// <summary>
        /// Constant USERPOOL for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType USERPOOL = new AuthenticationType("USERPOOL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetAttribute.
    /// </summary>
    public class FleetAttribute : ConstantClass
    {

        /// <summary>
        /// Constant VPC_CONFIGURATION for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute VPC_CONFIGURATION = new FleetAttribute("VPC_CONFIGURATION");
        /// <summary>
        /// Constant VPC_CONFIGURATION_SECURITY_GROUP_IDS for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute VPC_CONFIGURATION_SECURITY_GROUP_IDS = new FleetAttribute("VPC_CONFIGURATION_SECURITY_GROUP_IDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetAttribute FindValue(string value)
        {
            return FindValue<FleetAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetErrorCode.
    /// </summary>
    public class FleetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant IAM_SERVICE_ROLE_IS_MISSING for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_IS_MISSING = new FleetErrorCode("IAM_SERVICE_ROLE_IS_MISSING");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION");
        /// <summary>
        /// Constant IMAGE_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IMAGE_NOT_FOUND = new FleetErrorCode("IMAGE_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INTERNAL_SERVICE_ERROR = new FleetErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_SUBNET_CONFIGURATION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_SUBNET_CONFIGURATION = new FleetErrorCode("INVALID_SUBNET_CONFIGURATION");
        /// <summary>
        /// Constant NETWORK_INTERFACE_LIMIT_EXCEEDED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode NETWORK_INTERFACE_LIMIT_EXCEEDED = new FleetErrorCode("NETWORK_INTERFACE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES = new FleetErrorCode("SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode SUBNET_NOT_FOUND = new FleetErrorCode("SUBNET_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetErrorCode FindValue(string value)
        {
            return FindValue<FleetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetState.
    /// </summary>
    public class FleetState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for FleetState
        /// </summary>
        public static readonly FleetState RUNNING = new FleetState("RUNNING");
        /// <summary>
        /// Constant STARTING for FleetState
        /// </summary>
        public static readonly FleetState STARTING = new FleetState("STARTING");
        /// <summary>
        /// Constant STOPPED for FleetState
        /// </summary>
        public static readonly FleetState STOPPED = new FleetState("STOPPED");
        /// <summary>
        /// Constant STOPPING for FleetState
        /// </summary>
        public static readonly FleetState STOPPING = new FleetState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetState FindValue(string value)
        {
            return FindValue<FleetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageState.
    /// </summary>
    public class ImageState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ImageState
        /// </summary>
        public static readonly ImageState AVAILABLE = new ImageState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for ImageState
        /// </summary>
        public static readonly ImageState DELETING = new ImageState("DELETING");
        /// <summary>
        /// Constant FAILED for ImageState
        /// </summary>
        public static readonly ImageState FAILED = new ImageState("FAILED");
        /// <summary>
        /// Constant PENDING for ImageState
        /// </summary>
        public static readonly ImageState PENDING = new ImageState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageState FindValue(string value)
        {
            return FindValue<ImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStateChangeReasonCode.
    /// </summary>
    public class ImageStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE_BUILDER_NOT_AVAILABLE for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode IMAGE_BUILDER_NOT_AVAILABLE = new ImageStateChangeReasonCode("IMAGE_BUILDER_NOT_AVAILABLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode INTERNAL_ERROR = new ImageStateChangeReasonCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStateChangeReasonCode FindValue(string value)
        {
            return FindValue<ImageStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS = new PlatformType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackErrorCode.
    /// </summary>
    public class StackErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for StackErrorCode
        /// </summary>
        public static readonly StackErrorCode INTERNAL_SERVICE_ERROR = new StackErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant STORAGE_CONNECTOR_ERROR for StackErrorCode
        /// </summary>
        public static readonly StackErrorCode STORAGE_CONNECTOR_ERROR = new StackErrorCode("STORAGE_CONNECTOR_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackErrorCode FindValue(string value)
        {
            return FindValue<StackErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageConnectorType.
    /// </summary>
    public class StorageConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant HOMEFOLDERS for StorageConnectorType
        /// </summary>
        public static readonly StorageConnectorType HOMEFOLDERS = new StorageConnectorType("HOMEFOLDERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageConnectorType FindValue(string value)
        {
            return FindValue<StorageConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamSessionState.
    /// </summary>
    public class StreamSessionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState ACTIVE = new StreamSessionState("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState EXPIRED = new StreamSessionState("EXPIRED");
        /// <summary>
        /// Constant PENDING for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState PENDING = new StreamSessionState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamSessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamSessionState FindValue(string value)
        {
            return FindValue<StreamSessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamSessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisibilityType.
    /// </summary>
    public class VisibilityType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for VisibilityType
        /// </summary>
        public static readonly VisibilityType PRIVATE = new VisibilityType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for VisibilityType
        /// </summary>
        public static readonly VisibilityType PUBLIC = new VisibilityType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisibilityType FindValue(string value)
        {
            return FindValue<VisibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisibilityType(string value)
        {
            return FindValue(value);
        }
    }

}