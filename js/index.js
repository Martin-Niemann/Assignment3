Vue.createApp({
    data() {
        return {
            message: null,
            times: null,
            result: null
        }
    },
    methods: {
        execute() {
            this.result = "";

            if(this.times < 0) {
                this.result = "Must be a non-negative number: " + this.times;
            }

            for(let i = 0; i < this.times; i++) {
                this.result += this.message + " ";
            } 
        }
    }
}).mount("#app")