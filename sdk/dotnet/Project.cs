// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp-scaffold
{
    [Gcp-scaffoldResourceType("gcp-scaffold:index:project")]
    public partial class Project : Pulumi.ComponentResource
    {
        /// <summary>
        /// The ID of the project.
        /// </summary>
        [Output("projectID")]
        public Output<string> ProjectID { get; private set; } = null!;

        /// <summary>
        /// The display name of the project.
        /// </summary>
        [Output("projectName")]
        public Output<string> ProjectName { get; private set; } = null!;


        /// <summary>
        /// Create a Project resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Project(string name, ProjectArgs args, ComponentResourceOptions? options = null)
            : base("gcp-scaffold:index:project", name, args ?? new ProjectArgs(), MakeResourceOptions(options, ""), remote: true)
        {
        }

        private static ComponentResourceOptions MakeResourceOptions(ComponentResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ComponentResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ComponentResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProjectArgs : Pulumi.ResourceArgs
    {
        [Input("activatedApis")]
        private ImmutableArray<string>? _activatedApis;

        /// <summary>
        /// A list of APIs to be managed as part of the project
        /// </summary>
        public ImmutableArray<string> ActivatedApis
        {
            get => _activatedApis ?? (_activatedApis = new ImmutableArray<string>());
            set => _activatedApis = value;
        }

        /// <summary>
        /// The ID of the billing account this project belongs to. If not specified, then you may not specify APIs to activate for the project.
        /// </summary>
        [Input("billingAccountID")]
        public string? BillingAccountID { get; set; }

        /// <summary>
        /// The numeric ID of the folder this project should be created under. Conflicts with `orgID`.
        /// </summary>
        [Input("folderID")]
        public Input<string>? FolderID { get; set; }

        /// <summary>
        /// The numeric ID of the organization this project belongs to. Conflicts with `projectID`.
        /// </summary>
        [Input("orgID")]
        public string? OrgID { get; set; }

        /// <summary>
        /// The project ID.
        /// </summary>
        [Input("projectID", required: true)]
        public string ProjectID { get; set; } = null!;

        /// <summary>
        /// The display name of the project. ProjectID will be used as the display name if empty
        /// </summary>
        [Input("projectName")]
        public string? ProjectName { get; set; }

        public ProjectArgs()
        {
        }
    }
}
