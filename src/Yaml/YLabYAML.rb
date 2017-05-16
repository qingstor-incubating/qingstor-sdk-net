require "yaml"

class YYAML
    def load(file)
        YAML::load_file(file)
    end

    def parse(file)
        YAML::parse_file(file)
    end
end