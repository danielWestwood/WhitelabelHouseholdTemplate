//CheckBox Toggle

$(document).ready(function () {
    var JointPolicyHolderLabels = $(".editor-label-joint");
    var JointPolicyHolderFields = $(".editor-field-joint");
    var toggleCheck = $(".check-toggle");

    toggleCheck.on("click", function (event) {
        JointPolicyHolderLabels.toggle();
        JointPolicyHolderFields.toggle();
    });
});