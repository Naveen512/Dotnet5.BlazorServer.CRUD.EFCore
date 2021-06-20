window.global = {
  openModal: function (modalId) {
    modalId = "#" + modalId;
    $(modalId).modal("show");
  },
  closeModal: function (modalId) {
    modalId = "#" + modalId;
    $(modalId).modal("hide");
  },
};
